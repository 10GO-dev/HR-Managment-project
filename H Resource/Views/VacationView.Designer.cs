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
            Pb_txtVacation = new PictureBox();
            Pb_btnCloseVacation = new PictureBox();
            Pb_SearchBar = new PictureBox();
            Txtbox_SearchBar = new TextBox();
            Pb_Shape = new PictureBox();
            Pn_bgTablaVacation = new Panel();
            Tbl_layaut_Box = new TableLayoutPanel();
            Pb_btn_Edit = new PictureBox();
            Pb_btn_EditTxt = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pb_txtVacation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnCloseVacation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            Pn_bgTablaVacation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).BeginInit();
            SuspendLayout();
            // 
            // Pb_txtVacation
            // 
            Pb_txtVacation.Image = (Image)resources.GetObject("Pb_txtVacation.Image");
            Pb_txtVacation.Location = new Point(68, 12);
            Pb_txtVacation.Name = "Pb_txtVacation";
            Pb_txtVacation.Size = new Size(150, 36);
            Pb_txtVacation.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtVacation.TabIndex = 4;
            Pb_txtVacation.TabStop = false;
            // 
            // Pb_btnCloseVacation
            // 
            Pb_btnCloseVacation.Cursor = Cursors.Hand;
            Pb_btnCloseVacation.Image = Properties.Resources.img_close_button;
            Pb_btnCloseVacation.Location = new Point(991, 12);
            Pb_btnCloseVacation.Name = "Pb_btnCloseVacation";
            Pb_btnCloseVacation.Size = new Size(32, 25);
            Pb_btnCloseVacation.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btnCloseVacation.TabIndex = 5;
            Pb_btnCloseVacation.TabStop = false;
            Pb_btnCloseVacation.MouseEnter += Pb_btnCloseVacation_MouseEnter;
            Pb_btnCloseVacation.MouseLeave += Pb_btnCloseVacation_MouseLeave;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(446, 13);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(505, 30);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 12;
            Pb_SearchBar.TabStop = false;
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
            Pb_Shape.Location = new Point(454, 16);
            Pb_Shape.Name = "Pb_Shape";
            Pb_Shape.Size = new Size(24, 24);
            Pb_Shape.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Shape.TabIndex = 15;
            Pb_Shape.TabStop = false;
            // 
            // Pn_bgTablaVacation
            // 
            Pn_bgTablaVacation.BackColor = Color.FromArgb(237, 230, 219);
            Pn_bgTablaVacation.BackgroundImageLayout = ImageLayout.None;
            Pn_bgTablaVacation.Controls.Add(Tbl_layaut_Box);
            Pn_bgTablaVacation.Location = new Point(37, 49);
            Pn_bgTablaVacation.Name = "Pn_bgTablaVacation";
            Pn_bgTablaVacation.Size = new Size(950, 374);
            Pn_bgTablaVacation.TabIndex = 18;
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
            // Pb_btn_Edit
            // 
            Pb_btn_Edit.BackColor = Color.FromArgb(29, 92, 99);
            Pb_btn_Edit.Cursor = Cursors.Hand;
            Pb_btn_Edit.Image = (Image)resources.GetObject("Pb_btn_Edit.Image");
            Pb_btn_Edit.InitialImage = Properties.Resources.Img_Btn_New;
            Pb_btn_Edit.Location = new Point(993, 51);
            Pb_btn_Edit.Name = "Pb_btn_Edit";
            Pb_btn_Edit.Size = new Size(35, 32);
            Pb_btn_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_Edit.TabIndex = 20;
            Pb_btn_Edit.TabStop = false;
            Pb_btn_Edit.Paint += Pb_btn_Edit_Paint;
            Pb_btn_Edit.MouseEnter += Pb_btn_Edit_MouseEnter;
            Pb_btn_Edit.MouseLeave += Pb_btn_Edit_MouseLeave;
            // 
            // Pb_btn_EditTxt
            // 
            Pb_btn_EditTxt.BackColor = Color.FromArgb(237, 230, 219);
            Pb_btn_EditTxt.Cursor = Cursors.Hand;
            Pb_btn_EditTxt.Image = (Image)resources.GetObject("Pb_btn_EditTxt.Image");
            Pb_btn_EditTxt.Location = new Point(915, 52);
            Pb_btn_EditTxt.Name = "Pb_btn_EditTxt";
            Pb_btn_EditTxt.Size = new Size(100, 29);
            Pb_btn_EditTxt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_EditTxt.TabIndex = 19;
            Pb_btn_EditTxt.TabStop = false;
            Pb_btn_EditTxt.Visible = false;
            // 
            // VacationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 125, 122);
            ClientSize = new Size(1035, 450);
            Controls.Add(Pb_btn_Edit);
            Controls.Add(Pb_btn_EditTxt);
            Controls.Add(Pn_bgTablaVacation);
            Controls.Add(Pb_Shape);
            Controls.Add(Txtbox_SearchBar);
            Controls.Add(Pb_SearchBar);
            Controls.Add(Pb_btnCloseVacation);
            Controls.Add(Pb_txtVacation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VacationForm";
            Paint += VacationForm_Paint;
            ((System.ComponentModel.ISupportInitialize)Pb_txtVacation).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnCloseVacation).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            Pn_bgTablaVacation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_btn_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_EditTxt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pb_txtVacation;
        private PictureBox Pb_btnCloseVacation;
        private PictureBox Pb_SearchBar;
        private TextBox Txtbox_SearchBar;
        private PictureBox Pb_Shape;
        private Panel Pn_bgTablaVacation;
        private TableLayoutPanel Tbl_layaut_Box;
        private PictureBox Pb_btn_Edit;
        private PictureBox Pb_btn_EditTxt;
    }
}