﻿using System.Drawing.Drawing2D;
using System.Drawing;
using H_Resource.Models;
using Microsoft.IdentityModel.Tokens;
using H_Resource.Utilities;
using System.Linq.Expressions;
using H_Resource.Helpers;

namespace H_Resource.Views
{
    public partial class EmployeeDetailView : Form, IEmployeeDetailView
    {
        //Fields
        private string msg;
        private bool isSuccessful;
        private bool isEdit;

        public string EmployeeId { get => Lb_id.Text; set => Lb_id.Text = value; }
        public string FirstName { get => Txt_Name.Text; set => Txt_Name.Text = value; }
        public string LastName { get => Txt_LastName.Text; set => Txt_LastName.Text = value; }
        public DateTime? BirthDate { get => Dtp_Birthdate.Value; set => Dtp_Birthdate.Value = Convert.ToDateTime(value); }
        public int? GenderId { get => Convert.ToInt32(Cb_Gender.SelectedValue); set => Cb_Gender.SelectedIndex = Convert.ToInt32(value); }
        public string? Address { get => Txt_Address.Text; set => Txt_Address.Text = value; }
        public string Phone { get => Txt_Phone.Text; set => Txt_Phone.Text = value; }
        public string Email { get => Txt_Email.Text; set => Txt_Email.Text = value; }
        public Image? Image
        {
            get => Tools.CompareImages((Bitmap)Pb_imgPerfil.Image, Properties.Resources.Img_Avatar) ? null : Pb_imgPerfil.Image;
            set => Pb_imgPerfil.Image = value ?? Properties.Resources.Img_Avatar;
        }
        public DateTime? HireDate { get => Dtp_Dateofhire.Value; set => Dtp_Dateofhire.Value = Convert.ToDateTime(value); }
        public int? DepartmentId { get => Convert.ToInt16(cb_Department.SelectedValue); set => cb_Department.SelectedIndex = Convert.ToInt16(value); }
        public int? CountryId { get => Convert.ToInt16(cb_Nationality.SelectedValue); set => cb_Nationality.SelectedIndex = Convert.ToInt16(value); }
        public string Message { get => msg; set => msg = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public string DocuemntId { get => Txt_idcard.Text; set => Txt_idcard.Text = value; }
        public int Salary { get => Convert.ToInt32(Txt_Salary.Text); set => Txt_Salary.Text = value.ToString(); }

        private static EmployeeDetailView? instance;

        private EmployeeDetailView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //Btn Cancel
            BtnBack_EmployeeView.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            //Save Changes
        }

        //Singleton
        public static EmployeeDetailView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new EmployeeDetailView();
            instance.TopLevel = false;
            instance.Dock = DockStyle.Fill;
            return instance;
        }

        public event EventHandler<EventArgs>? ShowHomeView;
        public event EventHandler<EventArgs>? ShowEmployeesView;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        private void Pb_imgPerfil_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
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
            openFile.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;
            openFile.Title = "Seleccionar imagen";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(openFile.FileName).Length > 3 * 1024 * 1024) // Tamaño máximo de 3 MB en bytes
                {
                    MessageBox.Show("El tamaño de archivo seleccionado es mayor a 3 MB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Pb_imgPerfil.ImageLocation = openFile.FileName;
                Pb_imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void Txt_idcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.NumberOnly(e);

        }

        private void Txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.NumberOnly(e);
        }

        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.NumberOnly(e);
        }


        private void AddOrEditEmployeeView_SizeChanged(object sender, EventArgs e)
        {

            Lb_Title.Left = (this.Width / 2 - Lb_Title.Width / 2);
            if (this.Width > pn_form.MaximumSize.Width)
            {
                //pn_form.Anchor = (AnchorStyles)(Top | Bottom);
                pn_form.Left = (this.Width / 2 - pn_form.Width / 2);
            }
            pn_Avatar.Left = (pn_form.Width / 2 - pn_Avatar.Width / 2);
        }

        private void pn_form_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //int radius = 20;
            //int diameter = radius * 2;
            //Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            //// Esquina superior izquierda
            //GraphicsPath path = new GraphicsPath();
            //path.AddArc(rect, 180, 90);
            //path.AddLine(radius, 0, pn_form.Width - radius, 0);

            //// Esquina superior derecha
            //rect.X = pn_form.Width - diameter;
            //path.AddArc(rect, 270, 90);
            //path.AddLine(pn_form.Width, radius, pn_form.Width, pn_form.Height - radius);

            //// Esquina inferior derecha
            //rect.Y = pn_form.Height - diameter;
            //path.AddArc(rect, 0, 90);
            //path.AddLine(pn_form.Width - radius, pn_form.Height, radius, pn_form.Height);

            //// Esquina inferior izquierda
            //rect.X = 0;
            //path.AddArc(rect, 90, 90);
            //path.AddLine(0, pn_form.Height - radius, 0, radius);

            //path.CloseFigure();
            //pn_form.Region = new Region(path);
        }

        public void SetGenderComboBoxBindingSource(BindingSource genderList)
        {
            genderList.Insert(0, new GenderModel { Id = 0, Name = "--SELECCIONA" });
            Cb_Gender.DataSource = genderList;
            Cb_Gender.DisplayMember = "Name";
            Cb_Gender.ValueMember = "Id";
            //Cb_Gender.SelectedIndex = 0;
        }

        public void SetDepartmentComboBoxBindingSource(BindingSource departmentList)
        {
            departmentList.Insert(0, new DepartmentModel { DepartmentId = 0, DepartmentName = "--SELECCIONA" });
            cb_Department.DataSource = departmentList;
            cb_Department.DisplayMember = "DepartmentName";
            cb_Department.ValueMember = "DepartmentId";
            //cb_Department.SelectedIndex = 0;
        }

        public void SetCountryComboBoxBindingSource(BindingSource countryList)
        {
            countryList.Insert(0, new CountryModel { Id = 0, Name = "--SELECCIONA" });
            cb_Nationality.DataSource = countryList;
            cb_Nationality.DisplayMember = "Name";
            cb_Nationality.ValueMember = "Id";
            //cb_Nationality.SelectedIndex = 0;
        }

        public void setTitle(string title)
        {
            Lb_Title.Text = title;
        }

        public void enableButtons(bool value)
        {
            Pb_btnConfirmar.Enabled = value;
        }

        private void Pb_btnConfirmar_Click(object sender, EventArgs e)
        {
            enableButtons(false);
            SaveEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
