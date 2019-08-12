using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitWinformExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotAsync_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();
            var imageData = webClient.DownloadData("https://www.technocrazed.com/wp-content/uploads/2015/12/beautiful-wallpaper_279.jpg");
            pictureBox1.Image = Image.FromStream(new MemoryStream(imageData));
        }

        private async void btnAsyncTask_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();

            byte[] imageData = null;
            Task task = new Task(() =>
            {
                imageData = webClient.DownloadData("https://www.technocrazed.com/wp-content/uploads/2015/12/beautiful-wallpaper_279.jpg");
            });
            task.Start();
            await task;

            pictureBox1.Invoke((MethodInvoker)delegate
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(imageData));
            });
        }

        private async void btnAsyncDownloadMethod_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();
            byte[] imageData = await webClient.DownloadDataTaskAsync("https://www.technocrazed.com/wp-content/uploads/2015/12/beautiful-wallpaper_279.jpg");
            pictureBox1.Image  = Image.FromStream(new MemoryStream(imageData));
        }

        private void btnClearPicturebox_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
