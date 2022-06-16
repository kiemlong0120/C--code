using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//Khai báo sử dụng thư viện ICSharpCode.SharpZipLib.dll
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Core;

namespace nenflie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Hàm tạo file nén create zip có pass
        public void CreateSample(string outPathname, string password, string folderName)
        //outPathname: tên và đường dẫn lưu kết quả (ví dụ tên là ketqua.zip lưu ổ E, "E:\\ketqua.zip")
        //password: là password thiết lập cho file zip (ví dụ pass là "12345")
        //folderName: là đường dẫn folder dữ liệu (ví dụ có folder "data" ở ổ C, "C:\\data")
        //CreateSample("C:\\ketqua.zip", "12345", "C:\\data");
        //Chú ý nếu ketqua.zip đã tồn tại trong ổ E thì cần phải xóa bỏ file này thì mới tạo được
        {

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            FileStream fsOut = File.Create(outPathname);
            ZipOutputStream zipStream = new ZipOutputStream(fsOut);

            zipStream.SetLevel(3); //0-9,có 9 mức nén, mức 9 là cao nhất

            zipStream.Password = password;

            int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

            CompressFolder(folderName, zipStream, folderOffset);

            zipStream.IsStreamOwner = true;
            zipStream.Close();
            MessageBox.Show("Đã nén thành công", "Thông báo");
        }

        private void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            string[] files = Directory.GetFiles(path);

            foreach (string filename in files)
            {

                FileInfo fi = new FileInfo(filename);

                string entryName = filename.Substring(folderOffset);
                entryName = ZipEntry.CleanName(entryName);
                ZipEntry newEntry = new ZipEntry(entryName);
                newEntry.DateTime = fi.LastWriteTime;

                newEntry.Size = fi.Length;

                zipStream.PutNextEntry(newEntry);

                byte[] buffer = new byte[4096];
                using (FileStream streamReader = File.OpenRead(filename))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }
                zipStream.CloseEntry();
            }
            string[] folders = Directory.GetDirectories(path);
            foreach (string folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset);
            }


        }
        #endregion
        #region Hàm giải nén file zip có password
        public void ExtractZipFile(string archiveFilenameIn, string password, string outFolder)
        //archiveFilenameIn: đường dẫn file zip (ví dụ trong ổ E có file zip là ketqua.zip, "E:\\ketqua.zip")
        //password: là password đã đặt cho file zip như ví dụ trên là ketqua.zip(ví dụ "12345678")
        //outFolder: đường dẫn folder lưu kết quả giải nén (ví dụ trong ổ C có thư mục là data, "C:\\data")
        //ExtractZipFile("E:\\ketqua.zip","12345678","C:\\data")
        {
            try
            {
                ZipFile zf = null;
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                try
                {
                    FileStream fs = File.OpenRead(archiveFilenameIn);
                    zf = new ZipFile(fs);
                    if (!String.IsNullOrEmpty(password))
                    {

                        zf.Password = password;
                    }
                    foreach (ZipEntry zipEntry in zf)
                    {
                        if (!zipEntry.IsFile)
                        {
                            continue;
                        }
                        String entryFileName = zipEntry.Name;

                        byte[] buffer = new byte[4096];
                        Stream zipStream = zf.GetInputStream(zipEntry);

                        String fullZipToPath = Path.Combine(outFolder, entryFileName);
                        string directoryName = Path.GetDirectoryName(fullZipToPath);
                        if (directoryName.Length > 0)
                            Directory.CreateDirectory(directoryName);

                        if (System.IO.File.Exists(fullZipToPath) != true)
                        {
                            using (FileStream streamWriter = File.Create(fullZipToPath))
                            {
                                StreamUtils.Copy(zipStream, streamWriter, buffer);
                            }
                        }
                        else
                        {
                            using (FileStream streamWriter = new FileStream(fullZipToPath, FileMode.Append))
                            {
                                StreamUtils.Copy(zipStream, streamWriter, buffer);
                            }
                        }
                    }
                }
                finally
                {
                    if (zf != null)
                    {
                        zf.IsStreamOwner = true;
                        zf.Close();
                    }
                }
                MessageBox.Show("Đã giải nén thành công", "Thông báo");
            }
            catch 
            {
                MessageBox.Show("Lỗi tên file tiếng Việt! Vui lòng đổi tên file và thử lại");
            }
           
        }
        #endregion
        //Button Nén file thành file Zip
        private void btnnen_Click(object sender, EventArgs e)
        {
            string folderName="";
            MessageBox.Show("Chọn đường dẫn thư mục", "Thông báo");
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                folderName = f1.SelectedPath;        // đường dẫn được lưu vào pathSignatureEnCrypt 
            }
           
            CreateSample(folderName+".zip", "P@ssw0rdC@nnOtbeKn@w4cr3ck", folderName);
           
        }
        //Button Giải nén
        private void btngiainen_Click(object sender, EventArgs e)
        {
            string folderZipName="";
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folderZipName = dialog.FileName;  
                }
            }
            string folderName = "";
            MessageBox.Show("Chọn đường dẫn thư mục", "Thông báo");
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                folderName = f1.SelectedPath;        // đường dẫn được lưu vào pathSignatureEnCrypt 
            }
            ExtractZipFile(folderZipName, "P@ssw0rdC@nnOtbeKn@w4cr3ck", folderName+"\\"+ Path.GetFileName(folderZipName.Substring(0, folderZipName.Length - 4)));
          
        }
    }

}