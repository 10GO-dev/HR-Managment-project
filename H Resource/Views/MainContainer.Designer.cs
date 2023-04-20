namespace H_Resource.Views
{
    partial class MainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            pn_TitleBar = new Panel();
            btnMinimize = new PictureBox();
            btnMaximize = new PictureBox();
            btnClose = new PictureBox();
            pictureBox1 = new PictureBox();
            pn_Desktop = new Panel();
            pn_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pn_TitleBar
            // 
            pn_TitleBar.BackColor = Color.FromArgb(29, 92, 99);
            pn_TitleBar.Controls.Add(btnMinimize);
            pn_TitleBar.Controls.Add(btnMaximize);
            pn_TitleBar.Controls.Add(btnClose);
            pn_TitleBar.Controls.Add(pictureBox1);
            pn_TitleBar.Dock = DockStyle.Top;
            pn_TitleBar.Location = new Point(0, 0);
            pn_TitleBar.MaximumSize = new Size(0, 42);
            pn_TitleBar.Name = "pn_TitleBar";
            pn_TitleBar.Size = new Size(1083, 42);
            pn_TitleBar.TabIndex = 0;
            pn_TitleBar.MouseDown += pn_TitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Image = Properties.Resources.img_minimize_button;
            btnMinimize.Location = new Point(982, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Image = Properties.Resources.img_maximize_button;
            btnMaximize.Location = new Point(1015, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximize.TabIndex = 2;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.img_close_button;
            btnClose.Location = new Point(1048, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.LogoNameCornSilk;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pn_Desktop
            // 
            pn_Desktop.Dock = DockStyle.Fill;
            pn_Desktop.Location = new Point(0, 42);
            pn_Desktop.Name = "pn_Desktop";
            pn_Desktop.Size = new Size(1083, 552);
            pn_Desktop.TabIndex = 2;
            // 
            // MainContainer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1083, 594);
            Controls.Add(pn_Desktop);
            Controls.Add(pn_TitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainContainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HResource";
            Load += MainContainer_Load;
            Resize += MainContainer_Resize;
            pn_TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_TitleBar;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private PictureBox btnMaximize;
        private Panel pn_Desktop;
    }
}