﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr, int msg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = 0x20000; // Minimize borderless form from taskbar
                return cp;
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

        private void pb_btnClose_MouseEnter(object sender, EventArgs e)
        {
            pb_btnClose.Location = new Point(886, 17);
            pb_btnClose.Size = new Size(39, 39);
        }

        private void pb_btnClose_MouseLeave(object sender, EventArgs e)
        {
            pb_btnClose.Location = new Point(889, 20);
            pb_btnClose.Size = new Size(33, 33);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pn_drag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
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
    }
}