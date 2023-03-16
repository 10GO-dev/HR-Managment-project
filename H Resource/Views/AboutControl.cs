using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Resource.Views
{
    public partial class AboutControl : UserControl
    {
        string chrome = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
        public AboutControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/StevenP-2019-8372");
        }

        private void pb_img_brayan_aboutControl_Click_1(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/StevenP-2019-8372");
        }

        private void pb_img_chanel_aboutControl_Click(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/StevenP-2019-8372");
        }

        private void pb_img_diego_aboutControl_Click_1(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/10GO-dev");
        }

        private void pb_img_francisco_c_aboutControl_Click_1(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/francisco983412");

        }

        private void lbl_francisco_a_aboutControl_Click_1(object sender, EventArgs e)
        {
            Process.Start(chrome, "https://github.com/SongFrancisco");
        }
    }
}
