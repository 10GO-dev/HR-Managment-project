namespace H_Resource.Views
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            pn_btnPayroll = new Panel();
            pb_btnPayroll = new PictureBox();
            pn_btnVacation = new Panel();
            pb_btnVacation = new PictureBox();
            lbl_about = new Label();
            pn_btnEmployee = new Panel();
            pb_btnEmployee = new PictureBox();
            pb_HomeLogo = new PictureBox();
            pn_base = new Panel();
            aboutPage = new AboutControl();
            pn_btnPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnPayroll).BeginInit();
            pn_btnVacation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnVacation).BeginInit();
            pn_btnEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_HomeLogo).BeginInit();
            pn_base.SuspendLayout();
            SuspendLayout();
            // 
            // pn_btnPayroll
            // 
            pn_btnPayroll.Anchor = AnchorStyles.None;
            pn_btnPayroll.Controls.Add(pb_btnPayroll);
            pn_btnPayroll.Location = new Point(12, 266);
            pn_btnPayroll.Name = "pn_btnPayroll";
            pn_btnPayroll.Size = new Size(921, 80);
            pn_btnPayroll.TabIndex = 2;
            // 
            // pb_btnPayroll
            // 
            pb_btnPayroll.Anchor = AnchorStyles.None;
            pb_btnPayroll.Cursor = Cursors.Hand;
            pb_btnPayroll.Image = (Image)resources.GetObject("pb_btnPayroll.Image");
            pb_btnPayroll.Location = new Point(0, 0);
            pb_btnPayroll.Name = "pb_btnPayroll";
            pb_btnPayroll.Size = new Size(921, 80);
            pb_btnPayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnPayroll.TabIndex = 0;
            pb_btnPayroll.TabStop = false;
            pb_btnPayroll.Click += pb_btnPayroll_Click;
            pb_btnPayroll.MouseEnter += pb_btnPayroll_MouseEnter;
            pb_btnPayroll.MouseLeave += pb_btnPayroll_MouseLeave;
            // 
            // pn_btnVacation
            // 
            pn_btnVacation.Anchor = AnchorStyles.None;
            pn_btnVacation.Controls.Add(pb_btnVacation);
            pn_btnVacation.Location = new Point(12, 366);
            pn_btnVacation.Name = "pn_btnVacation";
            pn_btnVacation.Size = new Size(921, 80);
            pn_btnVacation.TabIndex = 3;
            // 
            // pb_btnVacation
            // 
            pb_btnVacation.Anchor = AnchorStyles.None;
            pb_btnVacation.Cursor = Cursors.Hand;
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
            lbl_about.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_about.AutoSize = true;
            lbl_about.Cursor = Cursors.Help;
            lbl_about.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbl_about.ForeColor = Color.FromArgb(237, 230, 219);
            lbl_about.Location = new Point(813, 460);
            lbl_about.Name = "lbl_about";
            lbl_about.Size = new Size(120, 20);
            lbl_about.TabIndex = 5;
            lbl_about.Text = ". Acerca de nosotros";
            lbl_about.Click += lbl_about_Click;
            // 
            // pn_btnEmployee
            // 
            pn_btnEmployee.Anchor = AnchorStyles.None;
            pn_btnEmployee.Controls.Add(pb_btnEmployee);
            pn_btnEmployee.Location = new Point(12, 164);
            pn_btnEmployee.Name = "pn_btnEmployee";
            pn_btnEmployee.Size = new Size(921, 80);
            pn_btnEmployee.TabIndex = 6;
            // 
            // pb_btnEmployee
            // 
            pb_btnEmployee.Anchor = AnchorStyles.None;
            pb_btnEmployee.Cursor = Cursors.Hand;
            pb_btnEmployee.Image = Properties.Resources.Img_Background_btn_employee;
            pb_btnEmployee.Location = new Point(0, 0);
            pb_btnEmployee.Name = "pb_btnEmployee";
            pb_btnEmployee.Size = new Size(921, 80);
            pb_btnEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnEmployee.TabIndex = 0;
            pb_btnEmployee.TabStop = false;
            pb_btnEmployee.MouseEnter += pb_btnEmployee_MouseEnter;
            pb_btnEmployee.MouseLeave += pb_btnEmployee_MouseLeave;
            // 
            // pb_HomeLogo
            // 
            pb_HomeLogo.Anchor = AnchorStyles.None;
            pb_HomeLogo.Image = Properties.Resources.HomeLogo;
            pb_HomeLogo.Location = new Point(367, 2);
            pb_HomeLogo.Name = "pb_HomeLogo";
            pb_HomeLogo.Size = new Size(210, 146);
            pb_HomeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_HomeLogo.TabIndex = 8;
            pb_HomeLogo.TabStop = false;
            // 
            // pn_base
            // 
            pn_base.BackColor = Color.FromArgb(26, 60, 64);
            pn_base.Controls.Add(aboutPage);
            pn_base.Controls.Add(pb_HomeLogo);
            pn_base.Controls.Add(lbl_about);
            pn_base.Controls.Add(pn_btnEmployee);
            pn_base.Controls.Add(pn_btnVacation);
            pn_base.Controls.Add(pn_btnPayroll);
            pn_base.Dock = DockStyle.Fill;
            pn_base.Location = new Point(0, 0);
            pn_base.MinimumSize = new Size(945, 489);
            pn_base.Name = "pn_base";
            pn_base.Size = new Size(945, 489);
            pn_base.TabIndex = 0;
            pn_base.Paint += pn_base_Paint;
            pn_base.MouseClick += pn_base_MouseClick;
            pn_base.Resize += pn_base_Resize;
            // 
            // aboutPage
            // 
            aboutPage.BackColor = Color.FromArgb(237, 230, 219);
            aboutPage.Location = new Point(528, 90);
            aboutPage.Name = "aboutPage";
            aboutPage.Size = new Size(405, 367);
            aboutPage.TabIndex = 9;
            aboutPage.Visible = false;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(945, 489);
            Controls.Add(pn_base);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += HomeScreenForm_Load;
            Paint += HomeScreenForm_Paint;
            MouseDown += HomeScreenForm_MouseDown;
            pn_btnPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnPayroll).EndInit();
            pn_btnVacation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnVacation).EndInit();
            pn_btnEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_btnEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_HomeLogo).EndInit();
            pn_base.ResumeLayout(false);
            pn_base.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_btnPayroll;
        private PictureBox pb_btnPayroll;
        private Panel pn_btnVacation;
        private PictureBox pb_btnVacation;
        private Label lbl_about;
        private Panel pn_btnEmployee;
        private PictureBox pb_btnEmployee;
        private PictureBox pb_HomeLogo;
        private Panel pn_base;
        private AboutControl aboutPage;
    }
}