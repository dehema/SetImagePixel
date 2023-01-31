using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SetImagePixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string folderPathStr = "";
        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.Description = "请选择文件夹";
            DialogResult d = folderBrowserDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                folderPathStr = folderBrowserDialog.SelectedPath;
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
            else
                txtFolderPath.Text = "请选择目录！";
        }

        List<string> filePathList = new List<string>();
        private void btSearchAllImage_Click(object sender, EventArgs e)
        {
            filePathList.Clear();
            string path = folderPathStr;
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files;
            files = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            foreach (var item in files)
                filePathList.Add(item.FullName);
            files = dir.GetFiles("*.png", SearchOption.AllDirectories);
            foreach (var item in files)
                filePathList.Add(item.FullName);
            RefreshListViewItem();
        }

        void RefreshListViewItem()
        {
            imageList.Items.Clear();
            for (int i = 0; i < filePathList.Count; i++)
            {
                string filePath = filePathList[i];
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = filePath.Replace(folderPathStr, "");
                imageList.Items.Add(lvi);
            }
        }

        List<string> newFilePathList = new List<string>();
        private void btChangePixel_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            newFilePathList.Clear();
            foreach (string filePath in filePathList)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromFile(filePath, false);
                Color c0 = bitmap.GetPixel(0, 0);
                Color c1 = bitmap.GetPixel(0, 1);
                Color c2 = bitmap.GetPixel(1, 0);
                Color color = Color.FromArgb((c1.A + c2.A) / 2, (c1.R + c2.R) / 2, (c1.G + c2.G) / 2, (c1.B + c2.B) / 2);
                if (color.R == c0.R)
                {
                    if (color.R > 128)
                    {
                        color = Color.FromArgb(color.A, color.R - 1, color.G, color.B);
                    }
                    else
                    {
                        color = Color.FromArgb(color.A, color.R + 1, color.G, color.B);
                    }
                }
                bitmap.SetPixel(0, 0, color);
                string extension = filePath.Substring(filePath.Length - 4, 4);
                string newFilePath = filePath.Remove(filePath.Length - 4, 4);
                string _fileName = newFilePath + "_1" + extension;
                newFilePathList.Add(_fileName);
                bitmap.Save(_fileName, extension == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png);
                bitmap.Dispose();
            }
            foreach (var path in newFilePathList)
            {
                string targetPath = path.Remove(path.Length - 6, 2);
                File.Copy(path, targetPath, true);
                File.Delete(path);
            }
            MessageBox.Show($"修改完成,共计{newFilePathList.Count}张图片,耗时{(DateTime.Now - d).TotalSeconds.ToString("f2")}秒");
        }
    }
}