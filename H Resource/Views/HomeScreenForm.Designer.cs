namespace H_Resource.Views
{
    partial class HomeScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            pn_drag = new Panel();
            pb_imgName = new PictureBox();
            pb_btnClose = new PictureBox();
            pn_btnPayroll = new Panel();
            pb_btnPayroll = new PictureBox();
            pn_btnVacation = new Panel();
            pb_btnVacation = new PictureBox();
            lbl_about = new Label();
            pn_btnEmployee = new Panel();
            pb_btnEmployee = new PictureBox();
            pn_base = new Panel();
            pn_drag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imgName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).BeginInit();
            pn_btnPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnPayroll).BeginInit();
            pn_btnVacation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnVacation).BeginInit();
            pn_btnEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnEmployee).BeginInit();
            pn_base.SuspendLayout();
            SuspendLayout();
            // 
            // pn_drag
            // 
            pn_drag.BackColor = Color.FromArgb(237, 230, 219);
            pn_drag.Controls.Add(pb_imgName);
            pn_drag.Controls.Add(pb_btnClose);
            pn_drag.Location = new Point(0, 0);
            pn_drag.Name = "pn_drag";
            pn_drag.Size = new Size(945, 59);
            pn_drag.TabIndex = 0;
            pn_drag.MouseDown += pn_drag_MouseDown;
            // 
            // pb_imgName
            // 
            pb_imgName.Image = Properties.Resources.Img_Name2;
            pb_imgName.Location = new Point(29, 9);
            pb_imgName.Name = "pb_imgName";
            pb_imgName.Size = new Size(120, 50);
            pb_imgName.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_imgName.TabIndex = 1;
            pb_imgName.TabStop = false;
            // 
            // pb_btnClose
            // 
            pb_btnClose.Cursor = Cursors.Hand;
            pb_btnClose.Image = (Image)resources.GetObject("pb_btnClose.Image");
            pb_btnClose.Location = new Point(894, 12);
            pb_btnClose.Name = "pb_btnClose";
            pb_btnClose.Size = new Size(33, 33);
            pb_btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnClose.TabIndex = 0;
            pb_btnClose.TabStop = false;
            pb_btnClose.Click += pb_btnClose_Click;
            pb_btnClose.MouseEnter += pb_btnClose_MouseEnter;
            pb_btnClose.MouseLeave += pb_btnClose_MouseLeave;
            // 
            // pn_btnPayroll
            // 
            pn_btnPayroll.Controls.Add(pb_btnPayroll);
            pn_btnPayroll.Location = new Point(12, 212);
            pn_btnPayroll.Name = "pn_btnPayroll";
            pn_btnPayroll.Size = new Size(921, 80);
            pn_btnPayroll.TabIndex = 2;
            // 
            // pb_btnPayroll
            // 
            pb_btnPayroll.Cursor = Cursors.Hand;
            pb_btnPayroll.Dock = DockStyle.Fill;
            pb_btnPayroll.Image = (Image)resources.GetObject("pb_btnPayroll.Image");
            pb_btnPayroll.Location = new Point(0, 0);
            pb_btnPayroll.Name = "pb_btnPayroll";
            pb_btnPayroll.Size = new Size(921, 80);
            pb_btnPayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnPayroll.TabIndex = 0;
            pb_btnPayroll.TabStop = false;
            pb_btnPayroll.MouseEnter += pb_btnPayroll_MouseEnter;
            pb_btnPayroll.MouseLeave += pb_btnPayroll_MouseLeave;
            // 
            // pn_btnVacation
            // 
            pn_btnVacation.Controls.Add(pb_btnVacation);
            pn_btnVacation.Location = new Point(12, 319);
            pn_btnVacation.Name = "pn_btnVacation";
            pn_btnVacation.Size = new Size(921, 80);
            pn_btnVacation.TabIndex = 3;
            // 
            // pb_btnVacation
            // 
            pb_btnVacation.Cursor = Cursors.Hand;
            pb_btnVacation.Dock = DockStyle.Fill;
            pb_btnVacation.Image = (Image)resources.GetObject("pb_btnVacation.Image");
            pb_btnVacation.Location = new Point(0, 0);
            pb_btnVacation.Name = "pb_btnVacation";
            pb_btnVacation.Size = new Size(921, 80);
            pb_btnVacation.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnVacation.TabIndex = 0;
            pb_btnVacation.TabStop = false;
            pb_btnVacation.MouseEnter += pb_btnVacation_MouseEnter;
            pb_btnVacation.MouseLeave += pb_btnVacation_MouseLeave;
            // 
            // lbl_about
            // 
            lbl_about.AutoSize = true;
            lbl_about.Cursor = Cursors.Help;
            lbl_about.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbl_about.ForeColor = Color.FromArgb(237, 230, 219);
            lbl_about.Location = new Point(790, 445);
            lbl_about.Name = "lbl_about";
            lbl_about.Size = new Size(120, 20);
            lbl_about.TabIndex = 5;
            lbl_about.Text = ". Acerca de nosotros";
            // 
            // pn_btnEmployee
            // 
            pn_btnEmployee.Controls.Add(pb_btnEmployee);
            pn_btnEmployee.Location = new Point(12, 108);
            pn_btnEmployee.Name = "pn_btnEmployee";
            pn_btnEmployee.Size = new Size(921, 80);
            pn_btnEmployee.TabIndex = 6;
            // 
            // pb_btnEmployee
            // 
            pb_btnEmployee.Cursor = Cursors.Hand;
            pb_btnEmployee.Dock = DockStyle.Fill;
            pb_btnEmployee.Image = Properties.Resources.Img_Background_btn_employee;
            pb_btnEmployee.Location = new Point(0, 0);
            pb_btnEmployee.Name = "pb_btnEmployee";
            pb_btnEmployee.Size = new Size(921, 80);
            pb_btnEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnEmployee.TabIndex = 0;
            pb_btnEmployee.TabStop = false;
            pb_btnEmployee.Click += pb_btnEmployee_Click;
            pb_btnEmployee.MouseEnter += pb_btnEmployee_MouseEnter;
            pb_btnEmployee.MouseLeave += pb_btnEmployee_MouseLeave;
            // 
            // pn_base
            // 
            pn_base.BackColor = Color.FromArgb(26, 60, 64);
            pn_base.Controls.Add(pn_btnEmployee);
            pn_base.Controls.Add(lbl_about);
            pn_base.Controls.Add(pn_btnVacation);
            pn_base.Controls.Add(pn_btnPayroll);
            pn_base.Controls.Add(pn_drag);
            pn_base.Dock = DockStyle.Fill;
            pn_base.Location = new Point(0, 0);
            pn_base.Name = "pn_base";
            pn_base.Size = new Size(945, 489);
            pn_base.TabIndex = 0;
            pn_base.Paint += pn_base_Paint;
            // 
            // HomeScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 489);
            Controls.Add(pn_base);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += HomeScreenForm_Load;
            Paint += HomeScreenForm_Paint;
            MouseDown += HomeScreenForm_MouseDown;
            pn_drag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_imgName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).EndInit();
            pn_btnPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnPayroll).EndInit();
            pn_btnVacation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnVacation).EndInit();
            pn_btnEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnEmployee).EndInit();
            pn_base.ResumeLayout(false);
            pn_base.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_drag;
        private PictureBox pb_imgName;
        private PictureBox pb_btnClose;
        private Panel pn_btnPayroll;
        private PictureBox pb_btnPayroll;
        private Panel pn_btnVacation;
        private PictureBox pb_btnVacation;
        private Label lbl_about;
        private Panel pn_btnEmployee;
        private PictureBox pb_btnEmployee;
        private Panel pn_base;
    }
}