using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Resource.Views
{
    public partial class Btn_Delete_EmployeesControl : UserControl
    {
        public Btn_Delete_EmployeesControl()
        {
            InitializeComponent();
        }

        private void Btn_Delete_EmployeesControl_Paint(object sender, PaintEventArgs e)
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

        private void Pb_btn_SiControler_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_SiControler.Image = Properties.Resources.img_Btn_Si_EmployeesControler_Hover;

        }

        private void Pb_btn_SiControler_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_SiControler.Image = Properties.Resources.img_Btn_Si_EmployeesControler;
        }

        private void Pb_btn_NoControler_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_NoControler.Image = Properties.Resources.img_Btn_No_EmployeesControler_Hover;
        }

        private void Pb_btn_NoControler_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_NoControler.Image = Properties.Resources.img_Btn_No_EmployeesControler;
        }

        private void Pb_btn_NoControler_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
