using System;
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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
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
        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }
        private void pb_btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HomeScreenForm_Paint(object sender, PaintEventArgs e)
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


        private void pb_btnClose_MouseLeave(object sender, EventArgs e)
        {
            pb_btnClose.Location = new Point(894, 12);
            pb_btnClose.Size = new Size(33, 33);
        }

        private void pb_btnClose_MouseEnter(object sender, EventArgs e)
        {
            pb_btnClose.Location = new Point(891, 9);
            pb_btnClose.Size = new Size(39, 39);
        }

        private void HomeScreenForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pn_drag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pn_btnEmployee_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pn_btnEmployee_MouseEnter(object sender, EventArgs e)
        {


        }

        private void pn_btnEmployee_MouseLeave(object sender, EventArgs e)
        {



        }

        private void pb_btnEmployee_MouseEnter(object sender, EventArgs e)
        {
            pb_btnEmployee.Image = Properties.Resources.Img_Background_btn_employeeHover;
            pb_btnEmployee.Update();
        }

        private void pb_btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            pb_btnEmployee.Image = Properties.Resources.Img_Background_btn_employee;
            pb_btnEmployee.Update();
        }


        private void pn_base_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pb_btnPayroll_MouseEnter(object sender, EventArgs e)
        {
            pb_btnPayroll.Image = Properties.Resources.Img_Background_btn_PayrollHover;
            pb_btnPayroll.Update();
        }

        private void pb_btnPayroll_MouseLeave(object sender, EventArgs e)
        {
            pb_btnPayroll.Image = Properties.Resources.Img_Background_btn_Payroll;
            pb_btnPayroll.Update();
        }

        private void pb_btnVacation_MouseLeave(object sender, EventArgs e)
        {
            pb_btnVacation.Image = Properties.Resources.Img_Background_btn_vacation;
            pb_btnVacation.Update();
        }

        private void pb_btnVacation_MouseEnter(object sender, EventArgs e)
        {
            pb_btnVacation.Image = Properties.Resources.Img_Background_btn_vacationHover;
            pb_btnVacation.Update();
        }
    }
}
