using Microsoft.EntityFrameworkCore.Update.Internal;
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
    public partial class HomeView : Form, IHomeView
    {
        private static HomeView? instance;

        public event EventHandler<EventArgs> ShowEmployeesView;

        private HomeView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pb_btnEmployee.Click += delegate { ShowEmployeesView?.Invoke(this, EventArgs.Empty); };
        }

        public static HomeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HomeView();
                instance.TopLevel = false;
                instance.MdiParent = parentContainer;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr, int msg, int wParam, int lParam);

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {

        }
        private void pb_btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HomeScreenForm_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //int radius = 20;
            //int diameter = radius * 2;
            //Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            //// Esquina superior izquierda
            //GraphicsPath path = new GraphicsPath();
            //path.AddArc(rect, 180, 90);
            //path.AddLine(radius, 0, this.Width - radius, 0);

            //// Esquina superior derecha
            //rect.X = this.Width - diameter;
            //path.AddArc(rect, 270, 90);
            //path.AddLine(this.Width, radius, this.Width, this.Height - radius);

            //// Esquina inferior derecha
            //rect.Y = this.Height - diameter;
            //path.AddArc(rect, 0, 90);
            //path.AddLine(this.Width - radius, this.Height, radius, this.Height);

            //// Esquina inferior izquierda
            //rect.X = 0;
            //path.AddArc(rect, 90, 90);
            //path.AddLine(0, this.Height - radius, 0, radius);

            //path.CloseFigure();
            //this.Region = new Region(path);
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

        private void lbl_about_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = aboutPage.Visible ? false : true;
            aboutPage.BringToFront();
        }

        private void pb_btnPayroll_Click(object sender, EventArgs e)
        {
            hideAboutPage();
            PayrollView payrollForm = new PayrollView();
            this.Hide();
            payrollForm.Show();
        }

        private void pb_btnVacation_Click(object sender, EventArgs e)
        {
            hideAboutPage();
            VacationView vacationForm = new VacationView();
            this.Hide();
            vacationForm.Show();
        }

        private void hideAboutPage()
        {
            aboutPage.Hide();
        }

        private void pn_base_Enter(object sender, EventArgs e)
        {
            hideAboutPage();
        }

        private void pn_base_MouseClick(object sender, MouseEventArgs e)
        {
            hideAboutPage();
        }

        private void pn_base_Resize(object sender, EventArgs e)
        {
            pn_btnEmployee.Left = ((this.Width / 2) - (pn_btnEmployee.Width / 2));
            aboutPage.Location = new Point(this.Width / 2 - aboutPage.Width / 2, this.Height / 2 - aboutPage.Height / 2);
            pb_HomeLogo.Location = new Point((this.Width / 2) - (pb_HomeLogo.Width / 2), pn_btnEmployee.Top / 2 - pb_HomeLogo.Height / 2);
        }

        private void pn_base_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
