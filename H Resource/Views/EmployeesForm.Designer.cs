namespace H_Resource.Views
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            Pb_txtEmployees = new PictureBox();
            Pb_btnCloseEmployees = new PictureBox();
            Pb_btn_NewTxt = new PictureBox();
            Pb_btn_DeleteTxt = new PictureBox();
            Pb_btn_EditTxt = new PictureBox();
            Pb_btn_New = new PictureBox();
            Pb_btn_Edit = new PictureBox();
            Pb_btn_Delete = new PictureBox();
            Tbl_layaut_Box = new TableLayoutPanel();
            Pn_bgTablaEmployees = new Panel();
            Pb_SearchBar = new PictureBox();
            Pb_Shape = new PictureBox();
            Txtbox_SearchBar = new TextBox();
            btn_Delete_EmployeesControl = new Btn_Delete_EmployeesControl();
            ((System.ComponentModel.ISupportInitialize)Pb_txtEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnCloseEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NewTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_DeleteTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_New).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Delete).BeginInit();
            Pn_bgTablaEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            SuspendLayout();
            // 
            // Pb_txtEmployees
            // 
            Pb_txtEmployees.Image = (Image)resources.GetObject("Pb_txtEmployees.Image");
            Pb_txtEmployees.Location = new Point(68, 12);
            Pb_txtEmployees.Name = "Pb_txtEmployees";
            Pb_txtEmployees.Size = new Size(150, 36);
            Pb_txtEmployees.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtEmployees.TabIndex = 0;
            Pb_txtEmployees.TabStop = false;
            // 
            // Pb_btnCloseEmployees
            // 
            Pb_btnCloseEmployees.Cursor = Cursors.Hand;
            Pb_btnCloseEmployees.Image = Properties.Resources.img_close_button2;
            Pb_btnCloseEmployees.Location = new Point(991, 12);
            Pb_btnCloseEmployees.Name = "Pb_btnCloseEmployees";
            Pb_btnCloseEmployees.Size = new Size(32, 25);
            Pb_btnCloseEmployees.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btnCloseEmployees.TabIndex = 2;
            Pb_btnCloseEmployees.TabStop = false;
            Pb_btnCloseEmployees.MouseEnter += Pb_btnCloseEmployees_MouseEnter;
            Pb_btnCloseEmployees.MouseLeave += Pb_btnCloseEmployees_MouseLeave;
            // 
            // Pb_btn_NewTxt
            // 
            Pb_btn_NewTxt.BackColor = Color.FromArgb(237, 230, 219);
            Pb_btn_NewTxt.Cursor = Cursors.Hand;
            Pb_btn_NewTxt.Image = (Image)resources.GetObject("Pb_btn_NewTxt.Image");
            Pb_btn_NewTxt.Location = new Point(915, 52);
            Pb_btn_NewTxt.Name = "Pb_btn_NewTxt";
            Pb_btn_NewTxt.Size = new Size(100, 29);
            Pb_btn_NewTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_NewTxt.TabIndex = 3;
            Pb_btn_NewTxt.TabStop = false;
            Pb_btn_NewTxt.Visible = false;
            // 
            // Pb_btn_DeleteTxt
            // 
            Pb_btn_DeleteTxt.BackColor = Color.FromArgb(237, 230, 219);
            Pb_btn_DeleteTxt.Cursor = Cursors.Hand;
            Pb_btn_DeleteTxt.Image = (Image)resources.GetObject("Pb_btn_DeleteTxt.Image");
            Pb_btn_DeleteTxt.Location = new Point(915, 122);
            Pb_btn_DeleteTxt.Name = "Pb_btn_DeleteTxt";
            Pb_btn_DeleteTxt.Size = new Size(100, 29);
            Pb_btn_DeleteTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_DeleteTxt.TabIndex = 5;
            Pb_btn_DeleteTxt.TabStop = false;
            Pb_btn_DeleteTxt.Visible = false;
            Pb_btn_DeleteTxt.Click += Pb_btn_Delete_Click;
            // 
            // Pb_btn_EditTxt
            // 
            Pb_btn_EditTxt.BackColor = Color.FromArgb(237, 230, 219);
            Pb_btn_EditTxt.Cursor = Cursors.Hand;
            Pb_btn_EditTxt.Image = (Image)resources.GetObject("Pb_btn_EditTxt.Image");
            Pb_btn_EditTxt.Location = new Point(915, 87);
            Pb_btn_EditTxt.Name = "Pb_btn_EditTxt";
            Pb_btn_EditTxt.Size = new Size(100, 29);
            Pb_btn_EditTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_EditTxt.TabIndex = 6;
            Pb_btn_EditTxt.TabStop = false;
            Pb_btn_EditTxt.Visible = false;
            // 
            // Pb_btn_New
            // 
            Pb_btn_New.Cursor = Cursors.Hand;
            Pb_btn_New.Image = (Image)resources.GetObject("Pb_btn_New.Image");
            Pb_btn_New.InitialImage = Properties.Resources.Img_Btn_New;
            Pb_btn_New.Location = new Point(993, 50);
            Pb_btn_New.Name = "Pb_btn_New";
            Pb_btn_New.Size = new Size(35, 32);
            Pb_btn_New.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_New.TabIndex = 7;
            Pb_btn_New.TabStop = false;
            Pb_btn_New.Paint += Pb_btn_New_Paint;
            Pb_btn_New.MouseEnter += Pb_btn_New_MouseEnter;
            Pb_btn_New.MouseLeave += Pb_btn_New_MouseLeave;
            // 
            // Pb_btn_Edit
            // 
            Pb_btn_Edit.BackColor = Color.FromArgb(29, 92, 99);
            Pb_btn_Edit.Cursor = Cursors.Hand;
            Pb_btn_Edit.Image = (Image)resources.GetObject("Pb_btn_Edit.Image");
            Pb_btn_Edit.InitialImage = Properties.Resources.Img_Btn_New;
            Pb_btn_Edit.Location = new Point(993, 86);
            Pb_btn_Edit.Name = "Pb_btn_Edit";
            Pb_btn_Edit.Size = new Size(35, 32);
            Pb_btn_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Edit.TabIndex = 8;
            Pb_btn_Edit.TabStop = false;
            Pb_btn_Edit.Paint += Pb_btn_Edit_Paint;
            Pb_btn_Edit.MouseEnter += Pb_btn_Edit_MouseEnter;
            Pb_btn_Edit.MouseLeave += Pb_btn_Edit_MouseLeave;
            // 
            // Pb_btn_Delete
            // 
            Pb_btn_Delete.BackColor = Color.FromArgb(26, 60, 64);
            Pb_btn_Delete.Cursor = Cursors.Hand;
            Pb_btn_Delete.Image = Properties.Resources.Img_Btn_Delete;
            Pb_btn_Delete.InitialImage = Properties.Resources.Img_Btn_New;
            Pb_btn_Delete.Location = new Point(993, 121);
            Pb_btn_Delete.Name = "Pb_btn_Delete";
            Pb_btn_Delete.Size = new Size(35, 32);
            Pb_btn_Delete.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Delete.TabIndex = 9;
            Pb_btn_Delete.TabStop = false;
            Pb_btn_Delete.Click += Pb_btn_Delete_Click;
            Pb_btn_Delete.Paint += Pb_btn_Delete_Paint;
            Pb_btn_Delete.MouseEnter += Pb_btn_Delete_MouseEnter;
            Pb_btn_Delete.MouseLeave += Pb_btn_Delete_MouseLeave;
            // 
            // Tbl_layaut_Box
            // 
            Tbl_layaut_Box.ColumnCount = 1;
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.Location = new Point(0, 0);
            Tbl_layaut_Box.Name = "Tbl_layaut_Box";
            Tbl_layaut_Box.RowCount = 2;
            Tbl_layaut_Box.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_layaut_Box.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_layaut_Box.Size = new Size(950, 377);
            Tbl_layaut_Box.TabIndex = 0;
            // 
            // Pn_bgTablaEmployees
            // 
            Pn_bgTablaEmployees.BackColor = Color.FromArgb(237, 230, 219);
            Pn_bgTablaEmployees.BackgroundImageLayout = ImageLayout.None;
            Pn_bgTablaEmployees.Controls.Add(Tbl_layaut_Box);
            Pn_bgTablaEmployees.Location = new Point(37, 49);
            Pn_bgTablaEmployees.Name = "Pn_bgTablaEmployees";
            Pn_bgTablaEmployees.Size = new Size(950, 374);
            Pn_bgTablaEmployees.TabIndex = 1;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(446, 13);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(505, 30);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 10;
            Pb_SearchBar.TabStop = false;
            // 
            // Pb_Shape
            // 
            Pb_Shape.BackColor = Color.FromArgb(237, 230, 219);
            Pb_Shape.Cursor = Cursors.Hand;
            Pb_Shape.Image = (Image)resources.GetObject("Pb_Shape.Image");
            Pb_Shape.Location = new Point(454, 16);
            Pb_Shape.Name = "Pb_Shape";
            Pb_Shape.Size = new Size(24, 24);
            Pb_Shape.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Shape.TabIndex = 11;
            Pb_Shape.TabStop = false;
            // 
            // Txtbox_SearchBar
            // 
            Txtbox_SearchBar.BackColor = Color.FromArgb(237, 230, 219);
            Txtbox_SearchBar.BorderStyle = BorderStyle.None;
            Txtbox_SearchBar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txtbox_SearchBar.ForeColor = Color.FromArgb(26, 60, 64);
            Txtbox_SearchBar.Location = new Point(484, 22);
            Txtbox_SearchBar.Name = "Txtbox_SearchBar";
            Txtbox_SearchBar.Size = new Size(455, 15);
            Txtbox_SearchBar.TabIndex = 12;
            Txtbox_SearchBar.Tag = "";
            Txtbox_SearchBar.Text = "Buscar";
            Txtbox_SearchBar.Enter += Txtbox_SearchBar_Enter;
            Txtbox_SearchBar.Leave += Txtbox_SearchBar_Leave;
            // 
            // btn_Delete_EmployeesControl
            // 
            btn_Delete_EmployeesControl.BackColor = Color.FromArgb(29, 92, 99);
            btn_Delete_EmployeesControl.Location = new Point(380, 35);
            btn_Delete_EmployeesControl.Name = "btn_Delete_EmployeesControl";
            btn_Delete_EmployeesControl.Size = new Size(375, 166);
            btn_Delete_EmployeesControl.TabIndex = 13;
            btn_Delete_EmployeesControl.Visible = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 125, 122);
            ClientSize = new Size(1035, 450);
            Controls.Add(btn_Delete_EmployeesControl);
            Controls.Add(Txtbox_SearchBar);
            Controls.Add(Pb_Shape);
            Controls.Add(Pb_SearchBar);
            Controls.Add(Pb_btn_Delete);
            Controls.Add(Pb_btn_Edit);
            Controls.Add(Pb_btn_New);
            Controls.Add(Pb_btn_EditTxt);
            Controls.Add(Pb_btn_DeleteTxt);
            Controls.Add(Pb_btn_NewTxt);
            Controls.Add(Pb_btnCloseEmployees);
            Controls.Add(Pn_bgTablaEmployees);
            Controls.Add(Pb_txtEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeesForm";
            Paint += EmployeesForm_Paint;
            ((System.ComponentModel.ISupportInitialize)Pb_txtEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnCloseEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NewTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_DeleteTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_New).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Delete).EndInit();
            Pn_bgTablaEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pb_txtEmployees;
        private PictureBox Pb_btnCloseEmployees;
        private PictureBox Pb_btn_NewTxt;
        private PictureBox Pb_btn_DeleteTxt;
        private PictureBox Pb_btn_EditTxt;
        private PictureBox Pb_btn_New;
        private PictureBox Pb_btn_Edit;
        private PictureBox Pb_btn_Delete;
        private TableLayoutPanel Tbl_layaut_Box;
        private Panel Pn_bgTablaEmployees;
        private PictureBox Pb_SearchBar;
        private PictureBox Pb_Shape;
        private TextBox Txtbox_SearchBar;
        private Btn_Delete_EmployeesControl btn_Delete_EmployeesControl;
    }
}