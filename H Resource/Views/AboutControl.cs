using H_Resource.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Resource.Views
{
    public partial class AboutControl : UserControl
    {

        public AboutControl()
        {
            InitializeComponent();
        }

        public static void GoToSite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GoToSite("https://github.com/StevenP-2019-8372");
        }

        private void pb_img_chanel_aboutControl_Click(object sender, EventArgs e)
        {
            GoToSite("https://github.com/Chanelp");
        }

        private void pb_img_diego_aboutControl_Click_1(object sender, EventArgs e)
        {
            GoToSite("https://github.com/10GO-dev");
        }

        private void pb_img_francisco_c_aboutControl_Click_1(object sender, EventArgs e)
        {
            GoToSite("https://github.com/francisco983412");

        }

        private void lbl_francisco_a_aboutControl_Click_1(object sender, EventArgs e)
        {
            GoToSite("https://github.com/SongFrancisco");
        }

        private void AboutControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 20;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            // Esquina superior izquierda
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180, 90);
            path.AddLine(radius, 0, this.Width - radius, 0);

            // Esquina superior derecha
            rect.X = this.Width - diameter;
            path.AddArc(rect, 270, 90);
            path.AddLine(this.Width, radius, this.Width, this.Height - radius);

            // Esquina inferior derecha
            rect.Y = this.Height - diameter;
            path.AddArc(rect, 0, 90);
            path.AddLine(this.Width - radius, this.Height, radius, this.Height);

            // Esquina inferior izquierda
            rect.X = 0;
            path.AddArc(rect, 90, 90);
            path.AddLine(0, this.Height - radius, 0, radius);

            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.img_close_button_hover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.img_about_btnClose;
        }
    }
}
