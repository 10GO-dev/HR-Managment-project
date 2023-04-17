namespace H_Resource.Views
{
    partial class VacationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationView));
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            Pb_txtVacation = new PictureBox();
            Pb_SearchBar = new PictureBox();
            Txtbox_SearchBar = new TextBox();
            Pb_Shape = new PictureBox();
            Pb_btn_Edit = new PictureBox();
            Pb_btn_EditTxt = new PictureBox();
            Dgv_VacationList = new DataGridView();
            btnBackHome = new PictureBox();
            cb_SearchFilter = new ComboBox();
            pb_FilterBg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pb_txtVacation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_VacationList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).BeginInit();
            SuspendLayout();
            // 
            // Pb_txtVacation
            // 
            Pb_txtVacation.Image = (Image)resources.GetObject("Pb_txtVacation.Image");
            Pb_txtVacation.Location = new Point(21, 20);
            Pb_txtVacation.Name = "Pb_txtVacation";
            Pb_txtVacation.Size = new Size(150, 56);
            Pb_txtVacation.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtVacation.TabIndex = 4;
            Pb_txtVacation.TabStop = false;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(392, 43);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(600, 43);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 12;
            Pb_SearchBar.TabStop = false;
            // 
            // Txtbox_SearchBar
            // 
            Txtbox_SearchBar.BackColor = Color.FromArgb(237, 230, 219);
            Txtbox_SearchBar.BorderStyle = BorderStyle.None;
            Txtbox_SearchBar.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txtbox_SearchBar.ForeColor = Color.FromArgb(26, 60, 64);
            Txtbox_SearchBar.Location = new Point(442, 54);
            Txtbox_SearchBar.Name = "Txtbox_SearchBar";
            Txtbox_SearchBar.Size = new Size(533, 22);
            Txtbox_SearchBar.TabIndex = 14;
            Txtbox_SearchBar.Tag = "";
            Txtbox_SearchBar.Text = "Buscar";
            Txtbox_SearchBar.Enter += Txtbox_SearchBar_Enter;
            Txtbox_SearchBar.Leave += Txtbox_SearchBar_Leave;
            // 
            // Pb_Shape
            // 
            Pb_Shape.BackColor = Color.FromArgb(237, 230, 219);
            Pb_Shape.Cursor = Cursors.Hand;
            Pb_Shape.Image = (Image)resources.GetObject("Pb_Shape.Image");
            Pb_Shape.Location = new Point(402, 51);
            Pb_Shape.Name = "Pb_Shape";
            Pb_Shape.Size = new Size(28, 28);
            Pb_Shape.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Shape.TabIndex = 15;
            Pb_Shape.TabStop = false;
            // 
            // Pb_btn_Edit
            // 
            Pb_btn_Edit.BackColor = Color.FromArgb(29, 92, 99);
            Pb_btn_Edit.Cursor = Cursors.Hand;
            Pb_btn_Edit.Image = Properties.Resources.img_btn_editEmployeeIco;
            Pb_btn_Edit.Location = new Point(1014, 215);
            Pb_btn_Edit.Name = "Pb_btn_Edit";
            Pb_btn_Edit.Size = new Size(48, 46);
            Pb_btn_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Edit.TabIndex = 20;
            Pb_btn_Edit.TabStop = false;
            Pb_btn_Edit.MouseEnter += Pb_btn_Edit_MouseEnter;
            Pb_btn_Edit.MouseLeave += Pb_btn_Edit_MouseLeave;
            // 
            // Pb_btn_EditTxt
            // 
            Pb_btn_EditTxt.BackColor = Color.FromArgb(237, 230, 219);
            Pb_btn_EditTxt.Cursor = Cursors.Hand;
            Pb_btn_EditTxt.Image = Properties.Resources.img_btn_editEmployeeLb;
            Pb_btn_EditTxt.Location = new Point(930, 222);
            Pb_btn_EditTxt.Name = "Pb_btn_EditTxt";
            Pb_btn_EditTxt.Size = new Size(90, 35);
            Pb_btn_EditTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_EditTxt.TabIndex = 19;
            Pb_btn_EditTxt.TabStop = false;
            Pb_btn_EditTxt.Visible = false;
            // 
            // Dgv_VacationList
            // 
            Dgv_VacationList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_VacationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_VacationList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dgv_VacationList.BackgroundColor = Color.White;
            Dgv_VacationList.BorderStyle = BorderStyle.None;
            Dgv_VacationList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle28.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle28.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = Color.FromArgb(237, 230, 219);
            dataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            Dgv_VacationList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            Dgv_VacationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            Dgv_VacationList.DefaultCellStyle = dataGridViewCellStyle29;
            Dgv_VacationList.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv_VacationList.EnableHeadersVisualStyles = false;
            Dgv_VacationList.GridColor = Color.Gray;
            Dgv_VacationList.Location = new Point(21, 141);
            Dgv_VacationList.Name = "Dgv_VacationList";
            Dgv_VacationList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Dgv_VacationList.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = Color.White;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(65, 125, 122);
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.ControlLightLight;
            Dgv_VacationList.RowsDefaultCellStyle = dataGridViewCellStyle30;
            Dgv_VacationList.RowTemplate.Height = 25;
            Dgv_VacationList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_VacationList.Size = new Size(969, 386);
            Dgv_VacationList.TabIndex = 21;
            Dgv_VacationList.Paint += Dgv_VacationList_Paint;
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
            btnBackHome.TabIndex = 22;
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
            cb_SearchFilter.Items.AddRange(new object[] { "Nombre", "Apellido", "Cédula", "Departamento", "Correo", "Teléfono" });
            cb_SearchFilter.Location = new Point(822, 101);
            cb_SearchFilter.Name = "cb_SearchFilter";
            cb_SearchFilter.Size = new Size(160, 27);
            cb_SearchFilter.TabIndex = 23;
            // 
            // pb_FilterBg
            // 
            pb_FilterBg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_FilterBg.Image = Properties.Resources.img_txt_EmployeeFilter;
            pb_FilterBg.Location = new Point(811, 94);
            pb_FilterBg.Name = "pb_FilterBg";
            pb_FilterBg.Size = new Size(179, 41);
            pb_FilterBg.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FilterBg.TabIndex = 24;
            pb_FilterBg.TabStop = false;
            // 
            // VacationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(1083, 552);
            Controls.Add(cb_SearchFilter);
            Controls.Add(pb_FilterBg);
            Controls.Add(btnBackHome);
            Controls.Add(Pb_btn_Edit);
            Controls.Add(Pb_btn_EditTxt);
            Controls.Add(Dgv_VacationList);
            Controls.Add(Pb_Shape);
            Controls.Add(Txtbox_SearchBar);
            Controls.Add(Pb_SearchBar);
            Controls.Add(Pb_txtVacation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VacationView";
            ((System.ComponentModel.ISupportInitialize)Pb_txtVacation).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_VacationList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBackHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_FilterBg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pb_txtVacation;
        private PictureBox Pb_SearchBar;
        private TextBox Txtbox_SearchBar;
        private PictureBox Pb_Shape;
        private PictureBox Pb_btn_Edit;
        private PictureBox Pb_btn_EditTxt;
        private DataGridView Dgv_VacationList;
        private PictureBox btnBackHome;
        private ComboBox cb_SearchFilter;
        private PictureBox pb_FilterBg;
    }
}