using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageDeletedChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private String selectedFile()
        {

            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.html";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            //ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter =
                "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに
            //「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                //Console.WriteLine(ofd.FileName);
                return ofd.FileName;
            }

            return "";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            lblHtmlFile.Text = selectedFile();

            loadUrls(lblHtmlFile.Text, lstImagesNew);
        }

        private void btnSelectPreviousHtml_Click(object sender, EventArgs e)
        {
            lblPreviousFile.Text = selectedFile();

            loadUrls(lblPreviousFile.Text, lstImagesPrevious);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            lstImagesDeleted.Items.Clear();

            for (int i = 0; i < lstImagesPrevious.Items.Count; i++)
            {
                string prevImage = (string)lstImagesPrevious.Items[i];

                for (int j = 0; j < lstImagesNew.Items.Count; j++)
                {
                    string newImage = (string)lstImagesNew.Items[j];

                    if (newImage.Equals(prevImage))
                    {
                        break;
                    }
                    else if (j == lstImagesNew.Items.Count - 1)
                    {
                        lstImagesDeleted.Items.Add(prevImage);
                    }
                }
            }

            if (lstImagesDeleted.Items.Count == 0)
            {
                MessageBox.Show("古いhtmlにのみ登場するimgタグ画像はありませんでした。");
            }
        }

        private void loadUrls(string filePath,ListBox lstTarget)
        {
            //"C:\test\1.txt"をShift-JISコードとして開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                filePath,
                System.Text.Encoding.GetEncoding("shift_jis"));


            //内容を一行ずつ読み込む
            string line="";
            string url = "";
            int startIndex = 0;
            int endIndex = 0;

            while (sr.Peek() > -1)
            {
                line = sr.ReadLine();
                //Console.WriteLine(line);
                startIndex = line.IndexOf("img src=");
                if (startIndex > 0)
                {
                    startIndex += 9;
                    endIndex = line.IndexOf("\"", startIndex);
                    if (endIndex > 0)
                    {
                        url = line.Substring(startIndex, endIndex - startIndex);
                        lstTarget.Items.Add(url);
                    }
                }
            }
            //閉じる
            sr.Close();
        }

        private void lstImagesDeleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedI = lstImagesDeleted.SelectedIndex;
            string url = (string)lstImagesDeleted.Items[selectedI];
            navigator(url);
        }

        private void navigator(string url)
        {
            if (url.Length > 4 && url.Substring(0, 4).Equals("http"))
            {
                webPreview.Navigate(url);
            }
            else
            {
                int index = lblHtmlFile.Text.LastIndexOf('\\');
                if (index < 0)
                {
                    return;
                }

                string file = lblHtmlFile.Text.Substring(0, index);
                file = file + "\\" + url;

                webPreview.Navigate(file);
            }
        }

        private void lstImagesPrevious_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedI = lstImagesPrevious.SelectedIndex;
            string url = (string)lstImagesPrevious.Items[selectedI];
            navigator(url);
        }

        private void lstImagesNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedI = lstImagesNew.SelectedIndex;
            string url = (string)lstImagesNew.Items[selectedI];
            navigator(url);
        }

        /*
        private string readText(String filePath)
        {
            //"C:\test\1.txt"をShift-JISコードとして開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                filePath,
                System.Text.Encoding.GetEncoding("shift_jis"));
            //内容をすべて読み込む
            string s = sr.ReadToEnd();
            //閉じる
            sr.Close();

            //結果を出力する
            return s;
        }

        private void cropSrcs(String code,ListBox lstTarget)
        {
            //var cursor = 0;     // カーソル。順次後ろへ
            var startIndex = 0; // img srcのURLの開始番地
            var endIndex = 0;   // img srcのURLの終了番地
            var url = "";

            for (int i = 0; i < 65530; i++)
            {
                startIndex = code.IndexOf("img src=",endIndex)+9;
                Console.WriteLine("startIndex:"+startIndex);

                if (startIndex == -1)
                {
                    i = 65534;
                    break;
                }
                
                endIndex = code.IndexOf("\"", startIndex);
                if (endIndex == -1)
                {
                    i = 65534;
                    break;
                }

                Console.WriteLine("endIndex:" + endIndex);


                url = code.Substring(startIndex, endIndex - startIndex);
                
                //lstTarget.Items.Add(url);

                Console.WriteLine(" " + url);

            }
        }
         */
    }
}
