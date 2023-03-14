using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Resource.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddLine(radius, 0, this.Width - radius, 0);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(this.Width, radius, this.Width, this.Height - radius);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddLine(this.Width - radius, this.Height, radius, this.Height);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, this.Height - radius, 0, radius);
            this.Region = new Region(path);
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

        }

        private void pb_btnLogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void pb_btnLogin_MouseEnter(object sender, EventArgs e)
        {
            pb_btnLogin.Image = Properties.Resources.Img_Background_btn_LoginHover;
            pb_btnLogin.Update();
        }

        private void pb_btnLogin_DragLeave(object sender, EventArgs e)
        {

        }

        private void pb_btnLogin_MouseLeave(object sender, EventArgs e)
        {
            pb_btnLogin.Image = Properties.Resources.Img_Background_btn_Login;
            pb_btnLogin.Update();
        }

        private void pb_btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
