using H_Resource.Helpers;
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
    public partial class VacationView : Form, IVacationView
    {

        private bool isCached;
        public string SearchValue { get => Txtbox_SearchBar.Text; set => Txtbox_SearchBar.Text = value; }
        public string SearchType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValueType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsCached { get => isCached; set => isCached = value; }

        public string FullName { get => txtName.Text; set => txtName.Text = value; }
        public string Department { get => txtDepartment.Text; set => txtDepartment.Text = value; }
        public string DocumentId { get => eDocumentID.Text; set => eDocumentID.Text = value; }
        public DateTime? HireDate { get => dtp_eHireDate.Value; set => dtp_eHireDate.Value = (DateTime)value; }
        public string AvailableDays { get => eAvailableDays.Text; set => eAvailableDays.Text = value; }
        public string TakenDays { get => eTakenDays.Text; set => eTakenDays.Text = value; }
        public DateTime StartDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image? Image
        {
            get => Tools.CompareImages((Bitmap)Pb_imgPerfil.Image, Properties.Resources.Img_Avatar) ? null : Pb_imgPerfil.Image;
            set => Pb_imgPerfil.Image = value ?? Properties.Resources.Img_Avatar;
        }

        private static VacationView? instance;

        private VacationView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Volver a Inicio
            btnBackHome.Click += delegate { ShowHomeView?.Invoke(this, EventArgs.Empty); };
            //Search Event
            Txtbox_SearchBar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //AddNew Event
            BtnAddNew.Click += delegate
            {

                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlVacationView.TabPages.Remove(tabPageVacationList);
                tabControlVacationView.TabPages.Add(tabPageAddOrEdit);
                tabPageAddOrEdit.Text = "Añadir Vacaciones";
            };
            //Edit Event
            BtnEdit.Click += delegate
            {

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlVacationView.TabPages.Remove(tabPageVacationList);
                tabControlVacationView.TabPages.Add(tabPageAddOrEdit);
                tabPageAddOrEdit.Text = "Editar Vacaciones";
            };
            //selectEmploye Event
            dgv_EmployeeList.CellContentClick += delegate { SelectEmployeeClick?.Invoke(this, EventArgs.Empty); };
        }

        public static VacationView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
                instance = new VacationView();
            instance.TopLevel = false;
            instance.MdiParent = parentContainer;
            instance.Dock = DockStyle.Fill;
            return instance;
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddEvent;
        public event EventHandler? RemoveEvent;
        public event EventHandler? EditEvent;
        public event EventHandler<EventArgs>? ShowHomeView;
        public event EventHandler SelectEmployeeClick;

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
            BtnEditLabel.Visible = BtnEditLabel.Visible ? false : true;
        }

        private void Pb_btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            BtnEditLabel.Visible = BtnEditLabel.Visible ? false : false;
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


        public void SetVacationListBindingSource(BindingSource vacationList)
        {
            Dgv_VacationList.DataSource = vacationList;
        }

        public void SetEmployeeDetailBindingSource(BindingSource employeeDetail)
        {
            dgv_EmployeeList.DataSource = employeeDetail;
        }
    }
}
