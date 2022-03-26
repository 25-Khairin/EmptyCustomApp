using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyCustomApp
{
    public partial class IDM : Form
    {
        private HttpDownloader httpDownload;

        public IDM()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Will Show User Save/Location Dialog 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save File Location";
            sfd.ShowDialog();
            txbSave.Text = sfd.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            httpDownload = new HttpDownloader(txbUrl.Text, txbSave.Text);
            httpDownload.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownload.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownload.Start();

        }

        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            lblPercentage.Text = $"{e.Progress.ToString("0.00")} %";
            lblSpeed.Text = string.Format("{0} MB/s", (e.SpeedInBytes/ 1024d / 1024d).ToString("0.00"));
            lblDownmb.Text = string.Format("{0} MB/s", (httpDownload.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            lblStatus.Text = "Downloading...";
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = "Finished!";
                lblPercentage.Text = "100 %";
            });
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(httpDownload != null)
            {
                httpDownload.Pause();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (httpDownload != null)
            {
                httpDownload.Resume();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Exits Application
            Application.Exit();
        }

        private void lblDownmb_Click(object sender, EventArgs e)
        {

        }
    }
}
