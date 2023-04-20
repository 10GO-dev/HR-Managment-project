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
    public partial class PayrollView : Form, IPayrollView
    {
        private static PayrollView instance;

        public event EventHandler SearchEvent;
        public event EventHandler<EventArgs> ShowHomeView;

        public string SearchValue { get => Txtbox_SearchBar.Text; set => Txtbox_SearchBar.Text = value; }

        public string? SearchCriteria => cb_SearchFilter.SelectedItem.ToString();

        public bool IsCached { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private PayrollView()
        {
            InitializeComponent();
            btnBackHome.Click += delegate { ShowHomeView?.Invoke(this, EventArgs.Empty); };
            //Search Event
            Txtbox_SearchBar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public static PayrollView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
                instance = new PayrollView();
            instance.TopLevel = false;
            instance.MdiParent = parentContainer;
            instance.Dock = DockStyle.Fill;
            return instance;
        }

        private void Txtbox_SearchBar_Enter(object sender, EventArgs e)
        {
            if (Txtbox_SearchBar.Text == $"Buscar por {cb_SearchFilter.SelectedItem}")
            {
                Txtbox_SearchBar.Text = "";

            }
        }

        private void Txtbox_SearchBar_Leave(object sender, EventArgs e)
        {
            if (Txtbox_SearchBar.Text.Length == 0 || string.IsNullOrWhiteSpace(Txtbox_SearchBar.Text))
            {
                Txtbox_SearchBar.Text = $"Buscar por {cb_SearchFilter.SelectedItem}";
            }
        }

        private void Dgv_PayrollList_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 14;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, diameter, diameter);
            // Esquina superior izquierda
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect, 180, 90);
            path.AddLine(radius, 0, Dgv_PayrollList.Width - radius, 0);

            // Esquina superior derecha
            rect.X = Dgv_PayrollList.Width - diameter;
            path.AddArc(rect, 270, 90);
            path.AddLine(Dgv_PayrollList.Width, radius, Dgv_PayrollList.Width, Dgv_PayrollList.Height - radius);

            // Esquina inferior derecha
            rect.Y = Dgv_PayrollList.Height - diameter;
            path.AddArc(rect, 0, 90);
            path.AddLine(Dgv_PayrollList.Width - radius, Dgv_PayrollList.Height, radius, Dgv_PayrollList.Height);

            // Esquina inferior izquierda
            rect.X = 0;
            path.AddArc(rect, 90, 90);
            path.AddLine(0, Dgv_PayrollList.Height - radius, 0, radius);

            path.CloseFigure();
            Dgv_PayrollList.Region = new Region(path);
        }

        public void SetPayrollsBindingSource(BindingSource payrolls)
        {
            Dgv_PayrollList.DataSource = payrolls;
        }

        private void PayrollView_Load(object sender, EventArgs e)
        {
            cb_SearchFilter.SelectedIndex = 0;
        }

        private void cb_SearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           Txtbox_SearchBar.Text = $"Buscar por {cb_SearchFilter.SelectedItem}";
        }
    }
}
