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
    public partial class VacationView : Form
    {
        public VacationView()
        {
            InitializeComponent();
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

        private void Pb_btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : true;
        }

        private void Pb_btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : false;
        }

        private void Dgv_VacationList_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 14;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            // Esquina superior izquierda
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180, 90);
            path.AddLine(radius, 0, Dgv_VacationList.Width - radius, 0);

            // Esquina superior derecha
            rect.X = Dgv_VacationList.Width - diameter;
            path.AddArc(rect, 270, 90);
            path.AddLine(Dgv_VacationList.Width, radius, Dgv_VacationList.Width, Dgv_VacationList.Height - radius);

            // Esquina inferior derecha
            rect.Y = Dgv_VacationList.Height - diameter;
            path.AddArc(rect, 0, 90);
            path.AddLine(Dgv_VacationList.Width - radius, Dgv_VacationList.Height, radius, Dgv_VacationList.Height);

            // Esquina inferior izquierda
            rect.X = 0;
            path.AddArc(rect, 90, 90);
            path.AddLine(0, Dgv_VacationList.Height - radius, 0, radius);

            path.CloseFigure();
            Dgv_VacationList.Region = new Region(path);
        }
    }
}
