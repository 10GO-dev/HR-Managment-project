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
    public partial class VacationForm : Form
    {
        public VacationForm()
        {
            InitializeComponent();
        }

        private void VacationForm_Paint(object sender, PaintEventArgs e)
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

        private void Pb_btnCloseVacation_MouseEnter(object sender, EventArgs e)
        {
            Pb_btnCloseVacation.Image = Properties.Resources.img_close_button_hover2;
        }

        private void Pb_btnCloseVacation_MouseLeave(object sender, EventArgs e)
        {
            Pb_btnCloseVacation.Image = Properties.Resources.img_close_button2;
        }

        private void Txtbox_SearchBar_Enter(object sender, EventArgs e)
        {
            if (Txtbox_SearchBar.Text == "Buscar")
            {
                Txtbox_SearchBar.Text = "";

            }
        }

        private void Txtbox_SearchBar_Leave(object sender, EventArgs e)
        {
            if (Txtbox_SearchBar.Text == "")
            {
                Txtbox_SearchBar.Text = "Buscar";

            }
        }

        private void Pb_btn_Edit_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, Pb_btn_Edit.Width - 1, Pb_btn_Edit.Height - 1);
            Region rg = new Region(gp);
            Pb_btn_Edit.Region = rg;
        }

        private void Pb_btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : true;
        }

        private void Pb_btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : false;
        }      
        
    }
}
