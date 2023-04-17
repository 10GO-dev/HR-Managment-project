namespace H_Resource.Views
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Pb_txtEmployees = new PictureBox();
            btnBackHome = new PictureBox();
            Pb_SearchBar = new PictureBox();
            Pb_Shape = new PictureBox();
            txt_SearchEmployee = new TextBox();
            cb_SearchFilter = new ComboBox();
            Pb_btn_EditTxt = new PictureBox();
            Pb_btn_NewTxt = new PictureBox();
            Pb_btn_Edit = new PictureBox();
            Pb_btn_New = new PictureBox();
            Pb_btn_Delete = new PictureBox();
            Dgv_EmployeeList = new DataGridView();
            Pb_btn_DeleteTxt = new PictureBox();
            pb_FilterBg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pb_txtEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NewTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_New).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Delete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_EmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_DeleteTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).BeginInit();
            SuspendLayout();
            // 
            // Pb_txtEmployees
            // 
            Pb_txtEmployees.Image = (Image)resources.GetObject("Pb_txtEmployees.Image");
            Pb_txtEmployees.Location = new Point(21, 20);
            Pb_txtEmployees.Name = "Pb_txtEmployees";
            Pb_txtEmployees.Size = new Size(150, 56);
            Pb_txtEmployees.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtEmployees.TabIndex = 0;
            Pb_txtEmployees.TabStop = false;
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
            btnBackHome.TabIndex = 2;
            btnBackHome.TabStop = false;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(392, 43);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(600, 43);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 10;
            Pb_SearchBar.TabStop = false;
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
            Pb_Shape.TabIndex = 11;
            Pb_Shape.TabStop = false;
            // 
            // txt_SearchEmployee
            // 
            txt_SearchEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_SearchEmployee.BackColor = Color.FromArgb(237, 230, 219);
            txt_SearchEmployee.BorderStyle = BorderStyle.None;
            txt_SearchEmployee.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SearchEmployee.ForeColor = Color.Black;
            txt_SearchEmployee.Location = new Point(442, 54);
            txt_SearchEmployee.Name = "txt_SearchEmployee";
            txt_SearchEmployee.Size = new Size(533, 22);
            txt_SearchEmployee.TabIndex = 12;
            txt_SearchEmployee.Tag = "";
            txt_SearchEmployee.Text = "Buscar";
            txt_SearchEmployee.Enter += Txtbox_SearchBar_Enter;
            txt_SearchEmployee.Leave += txt_SearchEmployee_Leave;
            // 
            // cb_SearchFilter
            // 
            cb_SearchFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_SearchFilter.BackColor = Color.FromArgb(237, 230, 219);
            cb_SearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_SearchFilter.FlatStyle = FlatStyle.Flat;
            cb_SearchFilter.Font = new Font("Segoe UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_SearchFilter.FormattingEnabled = true;
            cb_SearchFilter.Items.AddRange(new object[] { "Nombre", "Apellido", "Cédula", "Departamento", "Correo", "Teléfono" });
            cb_SearchFilter.Location = new Point(822, 101);
            cb_SearchFilter.Name = "cb_SearchFilter";
            cb_SearchFilter.Size = new Size(160, 27);
            cb_SearchFilter.TabIndex = 13;
            cb_SearchFilter.SelectedIndexChanged += cb_SearchFilter_SelectedIndexChanged;
            // 
            // Pb_btn_EditTxt
            // 
            Pb_btn_EditTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_EditTxt.BackColor = Color.White;
            Pb_btn_EditTxt.Cursor = Cursors.Hand;
            Pb_btn_EditTxt.Image = Properties.Resources.img_btn_editEmployeeLb;
            Pb_btn_EditTxt.Location = new Point(930, 222);
            Pb_btn_EditTxt.Name = "Pb_btn_EditTxt";
            Pb_btn_EditTxt.Size = new Size(90, 35);
            Pb_btn_EditTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_EditTxt.TabIndex = 6;
            Pb_btn_EditTxt.TabStop = false;
            Pb_btn_EditTxt.Visible = false;
            // 
            // Pb_btn_NewTxt
            // 
            Pb_btn_NewTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_NewTxt.BackColor = Color.White;
            Pb_btn_NewTxt.Cursor = Cursors.Hand;
            Pb_btn_NewTxt.Image = Properties.Resources.img_btn_newEmployeeLb;
            Pb_btn_NewTxt.Location = new Point(930, 164);
            Pb_btn_NewTxt.Name = "Pb_btn_NewTxt";
            Pb_btn_NewTxt.Size = new Size(90, 35);
            Pb_btn_NewTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_NewTxt.TabIndex = 3;
            Pb_btn_NewTxt.TabStop = false;
            Pb_btn_NewTxt.Visible = false;
            // 
            // Pb_btn_Edit
            // 
            Pb_btn_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_Edit.BackColor = Color.Transparent;
            Pb_btn_Edit.Cursor = Cursors.Hand;
            Pb_btn_Edit.Image = Properties.Resources.img_btn_editEmployeeIco;
            Pb_btn_Edit.Location = new Point(1014, 215);
            Pb_btn_Edit.Name = "Pb_btn_Edit";
            Pb_btn_Edit.Size = new Size(48, 46);
            Pb_btn_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Edit.TabIndex = 8;
            Pb_btn_Edit.TabStop = false;
            Pb_btn_Edit.MouseEnter += Pb_btn_Edit_MouseEnter;
            Pb_btn_Edit.MouseLeave += Pb_btn_Edit_MouseLeave;
            // 
            // Pb_btn_New
            // 
            Pb_btn_New.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_New.BackColor = Color.Transparent;
            Pb_btn_New.Cursor = Cursors.Hand;
            Pb_btn_New.Image = Properties.Resources.img_btn_AddEmployeeIco;
            Pb_btn_New.Location = new Point(1014, 157);
            Pb_btn_New.Name = "Pb_btn_New";
            Pb_btn_New.Size = new Size(50, 46);
            Pb_btn_New.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_New.TabIndex = 7;
            Pb_btn_New.TabStop = false;
            Pb_btn_New.MouseEnter += Pb_btn_New_MouseEnter;
            Pb_btn_New.MouseLeave += Pb_btn_New_MouseLeave;
            // 
            // Pb_btn_Delete
            // 
            Pb_btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_Delete.BackColor = Color.Transparent;
            Pb_btn_Delete.Cursor = Cursors.Hand;
            Pb_btn_Delete.Image = Properties.Resources.img_btn_delEmployeIco;
            Pb_btn_Delete.Location = new Point(1014, 273);
            Pb_btn_Delete.Name = "Pb_btn_Delete";
            Pb_btn_Delete.Size = new Size(48, 46);
            Pb_btn_Delete.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Delete.TabIndex = 9;
            Pb_btn_Delete.TabStop = false;
            Pb_btn_Delete.MouseEnter += Pb_btn_Delete_MouseEnter;
            Pb_btn_Delete.MouseLeave += Pb_btn_Delete_MouseLeave;
            // 
            // Dgv_EmployeeList
            // 
            Dgv_EmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_EmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_EmployeeList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv_EmployeeList.BackgroundColor = Color.White;
            Dgv_EmployeeList.BorderStyle = BorderStyle.None;
            Dgv_EmployeeList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgv_EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Dgv_EmployeeList.DefaultCellStyle = dataGridViewCellStyle2;
            Dgv_EmployeeList.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv_EmployeeList.EnableHeadersVisualStyles = false;
            Dgv_EmployeeList.GridColor = Color.Gray;
            Dgv_EmployeeList.Location = new Point(21, 141);
            Dgv_EmployeeList.Name = "Dgv_EmployeeList";
            Dgv_EmployeeList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Dgv_EmployeeList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLightLight;
            Dgv_EmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            Dgv_EmployeeList.RowTemplate.Height = 25;
            Dgv_EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_EmployeeList.Size = new Size(969, 386);
            Dgv_EmployeeList.TabIndex = 14;
            Dgv_EmployeeList.CellContentClick += Dgv_EmployeeList_CellContentClick;
            Dgv_EmployeeList.Paint += Dgv_EmployeeList_Paint;
            // 
            // Pb_btn_DeleteTxt
            // 
            Pb_btn_DeleteTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btn_DeleteTxt.BackColor = Color.White;
            Pb_btn_DeleteTxt.Cursor = Cursors.Hand;
            Pb_btn_DeleteTxt.ErrorImage = null;
            Pb_btn_DeleteTxt.Image = Properties.Resources.img_btn_delEmployeeLb;
            Pb_btn_DeleteTxt.Location = new Point(930, 279);
            Pb_btn_DeleteTxt.Name = "Pb_btn_DeleteTxt";
            Pb_btn_DeleteTxt.Size = new Size(90, 35);
            Pb_btn_DeleteTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_DeleteTxt.TabIndex = 5;
            Pb_btn_DeleteTxt.TabStop = false;
            Pb_btn_DeleteTxt.Visible = false;
            // 
            // pb_FilterBg
            // 
            pb_FilterBg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_FilterBg.Image = Properties.Resources.img_txt_EmployeeFilter;
            pb_FilterBg.Location = new Point(811, 94);
            pb_FilterBg.Name = "pb_FilterBg";
            pb_FilterBg.Size = new Size(179, 41);
            pb_FilterBg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FilterBg.TabIndex = 16;
            pb_FilterBg.TabStop = false;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(1083, 552);
            Controls.Add(Pb_btn_Delete);
            Controls.Add(Pb_btn_Edit);
            Controls.Add(Pb_btn_New);
            Controls.Add(Pb_btn_DeleteTxt);
            Controls.Add(Pb_btn_EditTxt);
            Controls.Add(Pb_btn_NewTxt);
            Controls.Add(cb_SearchFilter);
            Controls.Add(pb_FilterBg);
            Controls.Add(Dgv_EmployeeList);
            Controls.Add(txt_SearchEmployee);
            Controls.Add(Pb_Shape);
            Controls.Add(Pb_SearchBar);
            Controls.Add(btnBackHome);
            Controls.Add(Pb_txtEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeView";
            Load += EmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)Pb_txtEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NewTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_New).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Delete).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_EmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_DeleteTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pb_txtEmployees;
        private PictureBox btnBackHome;
        private PictureBox Pb_SearchBar;
        private PictureBox Pb_Shape;
        private TextBox txt_SearchEmployee;
        private ComboBox cb_SearchFilter;
        private PictureBox Pb_btn_EditTxt;
        private PictureBox Pb_btn_NewTxt;
        private PictureBox Pb_btn_Edit;
        private PictureBox Pb_btn_New;
        private PictureBox Pb_btn_Delete;
        private DataGridView Dgv_EmployeeList;
        private PictureBox Pb_btn_DeleteTxt;
        private PictureBox pb_FilterBg;
    }
}