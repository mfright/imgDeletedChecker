namespace imageDeletedChecker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelectNewHtml = new System.Windows.Forms.Button();
            this.lblHtmlFile = new System.Windows.Forms.Label();
            this.lstImagesNew = new System.Windows.Forms.ListBox();
            this.lstImagesPrevious = new System.Windows.Forms.ListBox();
            this.lblPreviousFile = new System.Windows.Forms.Label();
            this.btnSelectPreviousHtml = new System.Windows.Forms.Button();
            this.lstImagesDeleted = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.webPreview = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectNewHtml
            // 
            this.btnSelectNewHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectNewHtml.Location = new System.Drawing.Point(576, 7);
            this.btnSelectNewHtml.Name = "btnSelectNewHtml";
            this.btnSelectNewHtml.Size = new System.Drawing.Size(176, 25);
            this.btnSelectNewHtml.TabIndex = 0;
            this.btnSelectNewHtml.Text = "1. Select new html";
            this.btnSelectNewHtml.UseVisualStyleBackColor = false;
            this.btnSelectNewHtml.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblHtmlFile
            // 
            this.lblHtmlFile.AutoSize = true;
            this.lblHtmlFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHtmlFile.Location = new System.Drawing.Point(11, 7);
            this.lblHtmlFile.Name = "lblHtmlFile";
            this.lblHtmlFile.Size = new System.Drawing.Size(310, 12);
            this.lblHtmlFile.TabIndex = 1;
            this.lblHtmlFile.Text = "最新のHTMLファイルを選択。IMGタグは <img src=\" を含むこと。";
            // 
            // lstImagesNew
            // 
            this.lstImagesNew.FormattingEnabled = true;
            this.lstImagesNew.ItemHeight = 12;
            this.lstImagesNew.Location = new System.Drawing.Point(16, 86);
            this.lstImagesNew.Name = "lstImagesNew";
            this.lstImagesNew.Size = new System.Drawing.Size(287, 280);
            this.lstImagesNew.TabIndex = 2;
            // 
            // lstImagesPrevious
            // 
            this.lstImagesPrevious.FormattingEnabled = true;
            this.lstImagesPrevious.ItemHeight = 12;
            this.lstImagesPrevious.Location = new System.Drawing.Point(309, 86);
            this.lstImagesPrevious.Name = "lstImagesPrevious";
            this.lstImagesPrevious.Size = new System.Drawing.Size(300, 184);
            this.lstImagesPrevious.TabIndex = 3;
            // 
            // lblPreviousFile
            // 
            this.lblPreviousFile.AutoSize = true;
            this.lblPreviousFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPreviousFile.Location = new System.Drawing.Point(11, 33);
            this.lblPreviousFile.Name = "lblPreviousFile";
            this.lblPreviousFile.Size = new System.Drawing.Size(314, 12);
            this.lblPreviousFile.TabIndex = 4;
            this.lblPreviousFile.Text = "以前のHTMLファイルを選択。IMGタグは <img src=\"　を含むこと。";
            // 
            // btnSelectPreviousHtml
            // 
            this.btnSelectPreviousHtml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSelectPreviousHtml.Location = new System.Drawing.Point(576, 38);
            this.btnSelectPreviousHtml.Name = "btnSelectPreviousHtml";
            this.btnSelectPreviousHtml.Size = new System.Drawing.Size(176, 23);
            this.btnSelectPreviousHtml.TabIndex = 5;
            this.btnSelectPreviousHtml.Text = "2. Select previous html";
            this.btnSelectPreviousHtml.UseVisualStyleBackColor = false;
            this.btnSelectPreviousHtml.Click += new System.EventHandler(this.btnSelectPreviousHtml_Click);
            // 
            // lstImagesDeleted
            // 
            this.lstImagesDeleted.FormattingEnabled = true;
            this.lstImagesDeleted.ItemHeight = 12;
            this.lstImagesDeleted.Location = new System.Drawing.Point(615, 86);
            this.lstImagesDeleted.Name = "lstImagesDeleted";
            this.lstImagesDeleted.Size = new System.Drawing.Size(303, 184);
            this.lstImagesDeleted.TabIndex = 6;
            this.lstImagesDeleted.SelectedIndexChanged += new System.EventHandler(this.lstImagesDeleted_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "最新htmlの img src=\" の参照先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "以前のhtmlの img src=\"　の参照先";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(613, 71);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(196, 12);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "以前のhtmlにのみ含まれるimgの参照先";
            // 
            // webPreview
            // 
            this.webPreview.Location = new System.Drawing.Point(309, 276);
            this.webPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPreview.Name = "webPreview";
            this.webPreview.Size = new System.Drawing.Size(598, 297);
            this.webPreview.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "プレビュー";
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCompare.Location = new System.Drawing.Point(758, 7);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(149, 54);
            this.btnCompare.TabIndex = 12;
            this.btnCompare.Text = "3. COMPARE";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 585);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webPreview);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstImagesDeleted);
            this.Controls.Add(this.btnSelectPreviousHtml);
            this.Controls.Add(this.lblPreviousFile);
            this.Controls.Add(this.lstImagesPrevious);
            this.Controls.Add(this.lstImagesNew);
            this.Controls.Add(this.lblHtmlFile);
            this.Controls.Add(this.btnSelectNewHtml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IMG誤削除チェッカー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectNewHtml;
        private System.Windows.Forms.Label lblHtmlFile;
        private System.Windows.Forms.ListBox lstImagesNew;
        private System.Windows.Forms.ListBox lstImagesPrevious;
        private System.Windows.Forms.Label lblPreviousFile;
        private System.Windows.Forms.Button btnSelectPreviousHtml;
        private System.Windows.Forms.ListBox lstImagesDeleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.WebBrowser webPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompare;
    }
}

