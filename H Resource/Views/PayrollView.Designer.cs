namespace H_Resource.Views
{
    partial class PayrollView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Pb_txtPayroll = new PictureBox();
            Pb_SearchBar = new PictureBox();
            Txtbox_SearchBar = new TextBox();
            Pb_Shape = new PictureBox();
            Dgv_PayrollList = new DataGridView();
            btnBackHome = new PictureBox();
            cb_SearchFilter = new ComboBox();
            pb_FilterBg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pb_txtPayroll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_PayrollList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).BeginInit();
            SuspendLayout();
            // 
            // Pb_txtPayroll
            // 
            Pb_txtPayroll.Image = Properties.Resources.Img_Txt_Nomina;
            Pb_txtPayroll.Location = new Point(21, 20);
            Pb_txtPayroll.Name = "Pb_txtPayroll";
            Pb_txtPayroll.Size = new Size(150, 56);
            Pb_txtPayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtPayroll.TabIndex = 3;
            Pb_txtPayroll.TabStop = false;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(392, 43);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(600, 43);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 11;
            Pb_SearchBar.TabStop = false;
            // 
            // Txtbox_SearchBar
            // 
            Txtbox_SearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txtbox_SearchBar.BackColor = Color.FromArgb(237, 230, 219);
            Txtbox_SearchBar.BorderStyle = BorderStyle.None;
            Txtbox_SearchBar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbox_SearchBar.ForeColor = Color.FromArgb(26, 60, 64);
            Txtbox_SearchBar.Location = new Point(442, 54);
            Txtbox_SearchBar.Name = "Txtbox_SearchBar";
            Txtbox_SearchBar.Size = new Size(533, 22);
            Txtbox_SearchBar.TabIndex = 13;
            Txtbox_SearchBar.Tag = "";
            Txtbox_SearchBar.Text = "Buscar por Nombre";
            Txtbox_SearchBar.Enter += Txtbox_SearchBar_Enter;
            Txtbox_SearchBar.Leave += Txtbox_SearchBar_Leave;
            // 
            // Pb_Shape
            // 
            Pb_Shape.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_Shape.BackColor = Color.FromArgb(237, 230, 219);
            Pb_Shape.Cursor = Cursors.Hand;
            Pb_Shape.Image = (Image)resources.GetObject("Pb_Shape.Image");
            Pb_Shape.Location = new Point(402, 51);
            Pb_Shape.Name = "Pb_Shape";
            Pb_Shape.Size = new Size(28, 28);
            Pb_Shape.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Shape.TabIndex = 14;
            Pb_Shape.TabStop = false;
            // 
            // Dgv_PayrollList
            // 
            Dgv_PayrollList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_PayrollList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_PayrollList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv_PayrollList.BackgroundColor = Color.White;
            Dgv_PayrollList.BorderStyle = BorderStyle.None;
            Dgv_PayrollList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv_PayrollList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_PayrollList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgv_PayrollList.DefaultCellStyle = dataGridViewCellStyle2;
            Dgv_PayrollList.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv_PayrollList.EnableHeadersVisualStyles = false;
            Dgv_PayrollList.GridColor = Color.Gray;
            Dgv_PayrollList.Location = new Point(21, 141);
            Dgv_PayrollList.Name = "Dgv_PayrollList";
            Dgv_PayrollList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Dgv_PayrollList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            Dgv_PayrollList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Dgv_PayrollList.RowTemplate.Height = 25;
            Dgv_PayrollList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_PayrollList.Size = new Size(969, 386);
            Dgv_PayrollList.TabIndex = 15;
            Dgv_PayrollList.Paint += Dgv_PayrollList_Paint;
            // 
            // btnBackHome
            // 
            btnBackHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackHome.Cursor = Cursors.Hand;
            btnBackHome.Image = Properties.Resources.Icon_Back_Btn;
            btnBackHome.Location = new Point(1016, 21);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(47, 43);
            btnBackHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBackHome.TabIndex = 16;
            btnBackHome.TabStop = false;
            // 
            // cb_SearchFilter
            // 
            cb_SearchFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_SearchFilter.BackColor = Color.FromArgb(237, 230, 219);
            cb_SearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SearchFilter.FlatStyle = FlatStyle.Flat;
            cb_SearchFilter.Font = new Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_SearchFilter.FormattingEnabled = true;
            cb_SearchFilter.Items.AddRange(new object[] { "Nombre", "Apellido", "Departamento" });
            cb_SearchFilter.Location = new Point(822, 101);
            cb_SearchFilter.Name = "cb_SearchFilter";
            cb_SearchFilter.Size = new Size(160, 27);
            cb_SearchFilter.TabIndex = 17;
            cb_SearchFilter.SelectedIndexChanged += cb_SearchFilter_SelectedIndexChanged;
            // 
            // pb_FilterBg
            // 
            pb_FilterBg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_FilterBg.Image = Properties.Resources.img_txt_EmployeeFilter;
            pb_FilterBg.Location = new Point(811, 94);
            pb_FilterBg.Name = "pb_FilterBg";
            pb_FilterBg.Size = new Size(179, 41);
            pb_FilterBg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FilterBg.TabIndex = 18;
            pb_FilterBg.TabStop = false;
            // 
            // PayrollView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(1083, 552);
            Controls.Add(cb_SearchFilter);
            Controls.Add(pb_FilterBg);
            Controls.Add(btnBackHome);
            Controls.Add(Dgv_PayrollList);
            Controls.Add(Pb_Shape);
            Controls.Add(Txtbox_SearchBar);
            Controls.Add(Pb_SearchBar);
            Controls.Add(Pb_txtPayroll);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PayrollView";
            Load += PayrollView_Load;
            ((System.ComponentModel.ISupportInitialize)Pb_txtPayroll).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_PayrollList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Pb_txtPayroll;
        private PictureBox Pb_SearchBar;
        private TextBox Txtbox_SearchBar;
        private PictureBox Pb_Shape;
        private DataGridView Dgv_PayrollList;
        private PictureBox btnBackHome;
        private ComboBox cb_SearchFilter;
        private PictureBox pb_FilterBg;
    }
}