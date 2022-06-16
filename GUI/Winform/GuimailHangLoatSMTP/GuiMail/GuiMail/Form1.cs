using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;

namespace GuiMail
{
    public partial class Form1 : Form
    {
        Attachment attach = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                tbDinhKem.Text = dialog.FileName;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo flie = new FileInfo(tbDinhKem.Text);
                    attach = new Attachment(tbDinhKem.Text);
                }
                catch
                {
                }

                StreamReader sr = new StreamReader(tbGuiDen.Text);
                string email;
                while ((email = sr.ReadLine()) != null)
                {
                    GuiMail(tbUsername.Text, email, tbTieuDe.Text, tbNoiDung.Text);
                }
                sr.Close();
            }
            );
            thread.Start();
           
        }

        void GuiMail(string from, string to,string tieude,string noidung, Attachment file=null )
        {
            MailMessage message = new MailMessage(from, to, tieude, noidung);
            if (attach!=null)
            {
                message.Attachments.Add(attach);
            }
            
            SmtpClient client = new SmtpClient("smtp.gmail.com",587);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential(tbUsername.Text,tbPass.Text);

            client.Send(message);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbGuiDen.Text = dialog.FileName;
            }
        }
    }
}
