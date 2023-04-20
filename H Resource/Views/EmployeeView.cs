using H_Resource.Utilities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Resource.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        private string message;
        private static bool isCached;
        public string SearchValue { get => txt_SearchEmployee.Text; set => txt_SearchEmployee.Text = value; }
        public string? SearchCriteria => cb_SearchFilter.SelectedItem.ToString();

        public string Message { get => message; set => message = value; }
        public bool IsCached { get => isCached; set => isCached = value; }

        public int SelectedEmployeeIndex { get => selectedEmployeeIndex; }

        private static EmployeeView? instance;
        private int selectedEmployeeIndex;

        //Constructor
        private EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            this.DoubleBuffered = true;

        }

        //Singleton
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
                instance = new EmployeeView();
            instance.TopLevel = false;
            instance.MdiParent = parentContainer;
            instance.Dock = DockStyle.Fill;
            return instance;
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search Event
            txt_SearchEmployee.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Go Home Event
            btnBackHome.Click += delegate { ShowHomeView?.Invoke(this, EventArgs.Empty); };
            //Add New Employee event
            Pb_btn_New.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            //Edit Employee event
            Pb_btn_Edit.Click += (s, e) =>
            {
                if (Dgv_EmployeeList.SelectedRows.Count == 1)
                {
                    EditEvent?.Invoke(s, e);
                }
            };
            //Delete Employee Event
            Pb_btn_Delete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            };

            //SelectEmployee Event
            Dgv_EmployeeList.CellClick += (s, e) =>
            {
                selectedEmployeeIndex = e.RowIndex;
            };
        }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddNewEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;
        public event EventHandler<EventArgs>? ShowHomeView;
        public event EventHandler<EventArgs>? ShowAddOrEditView;
        public event EventHandler? EditEvent;
        public event EventHandler OnEmployeeDeleted;
        public event EventHandler OnEmployeeAdded;
        public event EventHandler OnEmployeeUpdated;


        private void Pb_btn_Delete_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_DeleteTxt.Visible = Pb_btn_DeleteTxt.Visible ? false : true;
        }

        private void Pb_btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_DeleteTxt.Visible = Pb_btn_DeleteTxt.Visible ? false : false;
        }

        private void Pb_btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : true;
        }

        private void Pb_btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_EditTxt.Visible = Pb_btn_EditTxt.Visible ? false : false;
        }

        private void Pb_btn_New_MouseEnter(object sender, EventArgs e)
        {
            Pb_btn_NewTxt.Visible = Pb_btn_NewTxt.Visible ? false : true;
        }

        private void Pb_btn_New_MouseLeave(object sender, EventArgs e)
        {
            Pb_btn_NewTxt.Visible = Pb_btn_NewTxt.Visible ? false : false;
        }

        private void Txtbox_SearchBar_Enter(object sender, EventArgs e)
        {
            if (txt_SearchEmployee.Text == $"Buscar por {cb_SearchFilter.SelectedItem}")
            {
                txt_SearchEmployee.Text = "";

            }
        }


        private void Dgv_EmployeeList_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 14;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            // Esquina superior izquierda
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180, 90);
            path.AddLine(radius, 0, Dgv_EmployeeList.Width - radius, 0);

            // Esquina superior derecha
            rect.X = Dgv_EmployeeList.Width - diameter;
            path.AddArc(rect, 270, 90);
            path.AddLine(Dgv_EmployeeList.Width, radius, Dgv_EmployeeList.Width, Dgv_EmployeeList.Height - radius);

            // Esquina inferior derecha
            rect.Y = Dgv_EmployeeList.Height - diameter;
            path.AddArc(rect, 0, 90);
            path.AddLine(Dgv_EmployeeList.Width - radius, Dgv_EmployeeList.Height, radius, Dgv_EmployeeList.Height);

            // Esquina inferior izquierda
            rect.X = 0;
            path.AddArc(rect, 90, 90);
            path.AddLine(0, Dgv_EmployeeList.Height - radius, 0, radius);

            path.CloseFigure();
            Dgv_EmployeeList.Region = new Region(path);
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            cb_SearchFilter.SelectedIndex = 0;
        }

        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            Dgv_EmployeeList.DataSource = employeeList;
        }

        private void cb_SearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = new string[2] { "Cédula", "Teléfono" };

            if (fields.Contains(cb_SearchFilter.SelectedItem))
            {

                txt_SearchEmployee.KeyPress += ValidateNumber;
            }
            else txt_SearchEmployee.KeyPress -= ValidateNumber;
            txt_SearchEmployee.Text = $"Buscar por {cb_SearchFilter.SelectedItem}";
        }

        private void txt_SearchEmployee_Leave(object sender, EventArgs e)
        {
            if (txt_SearchEmployee.Text.Length == 0 || string.IsNullOrWhiteSpace(txt_SearchEmployee.Text))
            {
                txt_SearchEmployee.Text = $"Buscar por {cb_SearchFilter.SelectedItem}";
            }
        }

        private void ValidateNumber(object sender, KeyPressEventArgs e) => InputValidation.NumberOnly(e);
    }
}
