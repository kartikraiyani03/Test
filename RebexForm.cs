using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebex.Net;

namespace MDI
{
    public partial class RebexForm : Form
    {
        public RebexForm()
        {
            InitializeComponent();
        }

        private string sftpHost = "192.168.29.189";
        private int sftpPort = 22; // Default SFTP port
        private string sftpUsername = "tester";
        private string sftpPassword = "password";

        private void RebexForm_Load(object sender, EventArgs e) { }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Rebex.Licensing.Key = "==AKV1T6EPr1JK43TgVYvXh55zE7nkKS/aWc8s5Z2B0Ung==";

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please select a valid file.");
                return;
            }

            string remotePath = Path.GetFileName(txtInput.Text); // Fixed remote path
            try
            {
                using (Sftp sftp = new Sftp())
                {
                    sftp.Connect(sftpHost, sftpPort);
                    sftp.Login(sftpUsername, sftpPassword);
                    sftp.PutFile(txtInput.Text, remotePath); // Fixed incorrect variable reference
                    sftp.Disconnect();
                    MessageBox.Show("File uploaded successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload failed: " + ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDest.Text))
            {
                MessageBox.Show("Enter the file name to download.");
                return;
            }

            string remotePath = txtDest.Text;
            saveFileDialog1.FileName = txtDest.Text;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Sftp sftp = new Sftp())
                    {
                        sftp.Connect(sftpHost, sftpPort);
                        sftp.Login(sftpUsername, sftpPassword);
                        sftp.GetFile(remotePath, saveFileDialog1.FileName); // Fixed method name from GelFile to GetFile
                        sftp.Disconnect();
                        MessageBox.Show("File downloaded successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Download failed: " + ex.Message);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog1.FileName;
            }
        }
    }
}
