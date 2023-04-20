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
        private int employeeId = 0;
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
        public DateTime? StartDate { get => Dtp_Startdate.Value; set => Dtp_Enddate.Value = (DateTime)value; }
        public DateTime? EndDate { get => Dtp_Enddate.Value; set => Dtp_Enddate.Value = (DateTime)value; }
        public Image? Image
        {
            get => Tools.CompareImages((Bitmap)Pb_imgPerfil.Image, Properties.Resources.Img_Avatar) ? null : Pb_imgPerfil.Image;
            set => Pb_imgPerfil.Image = value ?? Properties.Resources.Img_Avatar;
        }
        public int SelectedEmployeeIndex { get => selectedEmployeeIndex; }
        public int EmployeeID { get => employeeId; set => employeeId = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }

        public int SelectedVacationIndex => selectedVacationIndex;

        public int? VacationID { get => vacationID; set => vacationID = value?? 0; }

        private static VacationView? instance;
        private int selectedEmployeeIndex;
        private bool isEdit;
        private int selectedVacationIndex;
        private int vacationID;

        private VacationView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Volver a Inicio
            btnBackHome.Click += (s, e) =>
            {
                if (tabControlVacationView.TabPages.Contains(tabPageAddOrEdit))
                {
                    tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
                    tabControlVacationView.TabPages.Add(tabPageVacationList);
                    ResetTabVacationEdit();
                }
                else
                {
                    ShowHomeView?.Invoke(this, EventArgs.Empty);
                }
            };
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
                pn_employeeSelect.Visible = true;
                btnOpenEmployeeSelector.Visible = true;
                tabPageAddOrEdit.Text = "Añadir Vacaciones";
            };
            //Edit Event
            BtnEdit.Click += delegate
            {

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlVacationView.TabPages.Remove(tabPageVacationList);
                tabControlVacationView.TabPages.Add(tabPageAddOrEdit);
                pn_employeeSelect.Visible = false;
                btnOpenEmployeeSelector.Visible = false;
                tabPageAddOrEdit.Text = "Editar Vacaciones";
            };
            //selectEmploye Event
            dgv_EmployeeList.CellClick += (s, e) =>
            {
                selectedEmployeeIndex = e.RowIndex;
                SelectEmployeeClick?.Invoke(this, EventArgs.Empty);
            };
            //Save Vacation Event
            btnSave.Click += delegate { 
                
                SaveEvent?.Invoke(this, EventArgs.Empty);
            };
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
        public event EventHandler SaveEvent;

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
            dgv_EmployeeList.DataSource = null;
            dgv_EmployeeList.DataSource = employeeDetail;
        }

        private void btnLoadSelectedEmployee_Click(object sender, EventArgs e)
        {
            if (employeeId != 0)
            {
                pn_employeeSelect.Visible = false;
                return;
            }
            MessageBox.Show("Debes seleccionar un empleado para añadir una vacación");
        }

        private void btnOpenEmployeeSelector_Click(object sender, EventArgs e)
        {
            pn_employeeSelect.Visible = true;
        }

        private void btnCloseEmployeeSelector_Click(object sender, EventArgs e)
        {
            if (employeeId != 0)
            {
                pn_employeeSelect.Visible = false;
            }
            else
            {
                tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
                tabControlVacationView.TabPages.Add(tabPageVacationList);
                ResetTabVacationEdit();
                Txtbox_SearchBar.Focus();
            }

        }

        private void dgv_EmployeeList_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_EmployeeList.DataSource != null)
            {
                txtSelectEmployeeSearch.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
            tabControlVacationView.TabPages.Add(tabPageVacationList);
            ResetTabVacationEdit();
            Txtbox_SearchBar.Focus();
        }
        public void ResetTabVacationEdit()
        {
            employeeId = 0;
            txtName.Text = "";
            txtDepartment.Text = "";
            eDocumentID.Text = "";
            eAvailableDays.Text = "0";
            dtp_eHireDate.Value = DateTime.Today;
            Dtp_Startdate.Value = DateTime.Today;
            Dtp_Enddate.Value = DateTime.Today.AddDays(1);
            eTakenDays.Text = "0";
            Pb_imgPerfil.Image = Properties.Resources.Img_Avatar;
        }

        private void Dtp_Startdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Dtp_Startdate.Value.Date;
            DateTime currentDate = DateTime.Today;

            if (DateTime.Compare(selectedDate, currentDate) < 0)
            {
                MessageBox.Show("La fecha seleccionada debe ser mayor o igual a la fecha actual.");
                Dtp_Startdate.Value = currentDate;
            }
        }

        //private void Dtp_Enddate_ValueChanged(object sender, EventArgs e)
        //{
        //    int dias = (int)(Dtp_Enddate.Value - Dtp_Startdate.Value).TotalDays;
        //    if (DateTime.Compare(Dtp_Enddate.Value, Dtp_Startdate.Value) < 0)
        //    {
        //        MessageBox.Show("La fecha fin debe ser mayor que la fecha de inicio");
        //        Dtp_Enddate.Value = DateTime.Today.AddDays(1);
        //    }
        //    if (dias > Convert.ToInt16(AvailableDays))
        //    {
        //        MessageBox.Show("La cantidad de días no puede ser mayor a los días disponibles del empleado");
        //        Dtp_Enddate.Value = DateTime.Today.AddDays(1);
        //    }else
        //    {
        //        TakenDays = dias.ToString();
        //    }
        //}

        private void Pb_imgPerfil_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, Pb_imgPerfil.Width - 1, Pb_imgPerfil.Height - 1);
            Region rg = new Region(gp);
            Pb_imgPerfil.Region = rg;
        }

        public void GoBack()
        {
            tabControlVacationView.TabPages.Remove(tabPageAddOrEdit);
            tabControlVacationView.TabPages.Add(tabPageVacationList);
            ResetTabVacationEdit();
        }
    }
}