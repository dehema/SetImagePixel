namespace SetImagePixel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.Label();
            this.btSearchAllImage = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btChangePixel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(5, 21);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(96, 23);
            this.ChooseFolder.TabIndex = 0;
            this.ChooseFolder.Text = "选择文件夹";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.AutoSize = true;
            this.txtFolderPath.Location = new System.Drawing.Point(126, 24);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(68, 17);
            this.txtFolderPath.TabIndex = 1;
            this.txtFolderPath.Text = "文件夹路径";
            // 
            // btSearchAllImage
            // 
            this.btSearchAllImage.Location = new System.Drawing.Point(5, 64);
            this.btSearchAllImage.Name = "btSearchAllImage";
            this.btSearchAllImage.Size = new System.Drawing.Size(96, 23);
            this.btSearchAllImage.TabIndex = 2;
            this.btSearchAllImage.Text = "查找所有图片";
            this.btSearchAllImage.UseVisualStyleBackColor = true;
            this.btSearchAllImage.Click += new System.EventHandler(this.btSearchAllImage_Click);
            // 
            // imageList
            // 
            this.imageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.imageList.FullRowSelect = true;
            this.imageList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.imageList.Location = new System.Drawing.Point(126, 54);
            this.imageList.Name = "ImageList";
            this.imageList.Size = new System.Drawing.Size(933, 172);
            this.imageList.TabIndex = 3;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 999;
            // 
            // btChangePixel
            // 
            this.btChangePixel.Location = new System.Drawing.Point(5, 203);
            this.btChangePixel.Name = "btChangePixel";
            this.btChangePixel.Size = new System.Drawing.Size(96, 23);
            this.btChangePixel.TabIndex = 4;
            this.btChangePixel.Text = "修改像素";
            this.btChangePixel.UseVisualStyleBackColor = true;
            this.btChangePixel.Click += new System.EventHandler(this.btChangePixel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.btChangePixel);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.btSearchAllImage);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.ChooseFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChooseFolder;
        private Label txtFolderPath;
        private Button btSearchAllImage;
        private ListView imageList;
        private ColumnHeader columnHeader1;
        private Button btChangePixel;
    }
}