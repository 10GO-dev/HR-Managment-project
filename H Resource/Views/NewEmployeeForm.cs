using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using H_Resource.Models;

namespace H_Resource.Views
{
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void NewEmployeeForm_Paint(object sender, PaintEventArgs e)
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

        private void Pb_imgPerfil_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, Pb_imgPerfil.Width - 1, Pb_imgPerfil.Height - 1);
            Region rg = new Region(gp);
            Pb_imgPerfil.Region = rg;
        }

        private void Pb_btn_AddAvatar_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, Pb_btn_AddAvatar.Width - 1, Pb_btn_AddAvatar.Height - 1);
            Region rg = new Region(gp);
            Pb_btn_AddAvatar.Region = rg;
        }

        private void Pb_btn_AddAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Pb_imgPerfil.ImageLocation = openFile.FileName;
                Pb_imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Txt_idcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void Txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Cmbox_Department_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Seleccione una de las opciones ya establecidas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
        }

        private void ValidateInputs()
        {
            string FirsName = Txt_Name.Text.Trim();
            string LastName = Txt_LastName.Text.Trim();
            string Address = Txt_Address.Text.Trim();
            string Email = Txt_Email.Text.Trim();
            string Phone = Txt_Phone.Text.Trim();
            Image Image = Pb_imgPerfil.Image;
            
            DateOnly HireDate = DateOnly.FromDateTime(Dtp_Dateofhire.Value);
            DateOnly BirthDate = DateOnly.FromDateTime(Dtp_Dateofhire.Value);
            
            if (string.IsNullOrEmpty(FirsName))
            {
                throw new Exception("El campo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(LastName))
            {
                throw new Exception("El campo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(Address))
            {
                throw new Exception("El campo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(Email))
            {

                throw new Exception("El campo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(Phone))
            {
                Txt_Phone.Focus();
                throw new Exception("El campo no puede estar vacio");
            }
            if (Image == null || Image == Properties.Resources.Img_Avatar)
            {
                throw new Exception("Debes agregar una imagen");
            }

        }

        private void AddEmployee()
        {
            string FirsName = Txt_Name.Text.Trim();
            string LastName = Txt_LastName.Text.Trim();
            string Address = Txt_Address.Text.Trim();
            string Email = Txt_Email.Text.Trim();
            string Phone = Txt_Phone.Text.Trim();

            DateOnly HireDate = DateOnly.FromDateTime(Dtp_Dateofhire.Value);
            DateOnly BirthDate = DateOnly.FromDateTime(Dtp_Dateofhire.Value);
            using (HrmsDbContext db = new HrmsDbContext())
            {
                
                Employee employee = new Employee
                {
                    FirstName = FirsName,
                    LastName = LastName,
                    Address = Address,
                    Email = Email,
                    Phone = Phone,
                };
            }
        }

        private void Pb_btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                AddEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
