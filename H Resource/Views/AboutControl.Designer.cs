namespace H_Resource.Views
{
    partial class AboutControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutControl));
            pb_name_aboutControl = new PictureBox();
            pb_img_steven_aboutControl = new PictureBox();
            lbl_steven_aboutControl = new Label();
            lbl_francisco_a_aboutControl = new Label();
            lbl_francisco_c_aboutControl = new Label();
            lbl_diego_aboutControl = new Label();
            lbl_chanel_aboutControl = new Label();
            pb_img_francisco_a_aboutControl = new PictureBox();
            pb_img_francisco_c_aboutControl = new PictureBox();
            pb_img_diego_aboutControl = new PictureBox();
            pb_img_chanel_aboutControl = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_name_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_steven_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_francisco_a_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_francisco_c_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_diego_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_chanel_aboutControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb_name_aboutControl
            // 
            pb_name_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_name_aboutControl.BackgroundImageLayout = ImageLayout.None;
            pb_name_aboutControl.Image = Properties.Resources.Img_logoName;
            pb_name_aboutControl.Location = new Point(30, 17);
            pb_name_aboutControl.Name = "pb_name_aboutControl";
            pb_name_aboutControl.Size = new Size(150, 43);
            pb_name_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_name_aboutControl.TabIndex = 4;
            pb_name_aboutControl.TabStop = false;
            // 
            // pb_img_steven_aboutControl
            // 
            pb_img_steven_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_img_steven_aboutControl.Image = (Image)resources.GetObject("pb_img_steven_aboutControl.Image");
            pb_img_steven_aboutControl.Location = new Point(221, 217);
            pb_img_steven_aboutControl.Name = "pb_img_steven_aboutControl";
            pb_img_steven_aboutControl.Size = new Size(75, 69);
            pb_img_steven_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img_steven_aboutControl.TabIndex = 0;
            pb_img_steven_aboutControl.TabStop = false;
            pb_img_steven_aboutControl.Click += pictureBox6_Click;
            // 
            // lbl_steven_aboutControl
            // 
            lbl_steven_aboutControl.AutoSize = true;
            lbl_steven_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            lbl_steven_aboutControl.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_steven_aboutControl.ForeColor = Color.FromArgb(26, 60, 64);
            lbl_steven_aboutControl.Location = new Point(241, 289);
            lbl_steven_aboutControl.Name = "lbl_steven_aboutControl";
            lbl_steven_aboutControl.Size = new Size(39, 16);
            lbl_steven_aboutControl.TabIndex = 10;
            lbl_steven_aboutControl.Text = "Steven";
            lbl_steven_aboutControl.Click += pictureBox6_Click;
            // 
            // lbl_francisco_a_aboutControl
            // 
            lbl_francisco_a_aboutControl.AutoSize = true;
            lbl_francisco_a_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            lbl_francisco_a_aboutControl.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_francisco_a_aboutControl.ForeColor = Color.FromArgb(26, 60, 64);
            lbl_francisco_a_aboutControl.Location = new Point(98, 289);
            lbl_francisco_a_aboutControl.Name = "lbl_francisco_a_aboutControl";
            lbl_francisco_a_aboutControl.Size = new Size(65, 16);
            lbl_francisco_a_aboutControl.TabIndex = 11;
            lbl_francisco_a_aboutControl.Text = "Francisco A.";
            lbl_francisco_a_aboutControl.Click += lbl_francisco_a_aboutControl_Click_1;
            // 
            // lbl_francisco_c_aboutControl
            // 
            lbl_francisco_c_aboutControl.AutoSize = true;
            lbl_francisco_c_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            lbl_francisco_c_aboutControl.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_francisco_c_aboutControl.ForeColor = Color.FromArgb(26, 60, 64);
            lbl_francisco_c_aboutControl.Location = new Point(291, 169);
            lbl_francisco_c_aboutControl.Name = "lbl_francisco_c_aboutControl";
            lbl_francisco_c_aboutControl.Size = new Size(65, 16);
            lbl_francisco_c_aboutControl.TabIndex = 12;
            lbl_francisco_c_aboutControl.Text = "Francisco C.";
            lbl_francisco_c_aboutControl.Click += pb_img_francisco_c_aboutControl_Click_1;
            // 
            // lbl_diego_aboutControl
            // 
            lbl_diego_aboutControl.AutoSize = true;
            lbl_diego_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            lbl_diego_aboutControl.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_diego_aboutControl.ForeColor = Color.FromArgb(26, 60, 64);
            lbl_diego_aboutControl.Location = new Point(178, 169);
            lbl_diego_aboutControl.Name = "lbl_diego_aboutControl";
            lbl_diego_aboutControl.Size = new Size(34, 16);
            lbl_diego_aboutControl.TabIndex = 14;
            lbl_diego_aboutControl.Text = "Diego";
            lbl_diego_aboutControl.Click += pb_img_diego_aboutControl_Click_1;
            // 
            // lbl_chanel_aboutControl
            // 
            lbl_chanel_aboutControl.AutoSize = true;
            lbl_chanel_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            lbl_chanel_aboutControl.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_chanel_aboutControl.ForeColor = Color.FromArgb(26, 60, 64);
            lbl_chanel_aboutControl.Location = new Point(50, 169);
            lbl_chanel_aboutControl.Name = "lbl_chanel_aboutControl";
            lbl_chanel_aboutControl.Size = new Size(39, 16);
            lbl_chanel_aboutControl.TabIndex = 15;
            lbl_chanel_aboutControl.Text = "Chanel";
            lbl_chanel_aboutControl.Click += pb_img_chanel_aboutControl_Click;
            // 
            // pb_img_francisco_a_aboutControl
            // 
            pb_img_francisco_a_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_img_francisco_a_aboutControl.Image = (Image)resources.GetObject("pb_img_francisco_a_aboutControl.Image");
            pb_img_francisco_a_aboutControl.Location = new Point(93, 217);
            pb_img_francisco_a_aboutControl.Name = "pb_img_francisco_a_aboutControl";
            pb_img_francisco_a_aboutControl.Size = new Size(75, 69);
            pb_img_francisco_a_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img_francisco_a_aboutControl.TabIndex = 0;
            pb_img_francisco_a_aboutControl.TabStop = false;
            pb_img_francisco_a_aboutControl.Click += lbl_francisco_a_aboutControl_Click_1;
            // 
            // pb_img_francisco_c_aboutControl
            // 
            pb_img_francisco_c_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_img_francisco_c_aboutControl.Image = (Image)resources.GetObject("pb_img_francisco_c_aboutControl.Image");
            pb_img_francisco_c_aboutControl.Location = new Point(286, 97);
            pb_img_francisco_c_aboutControl.Name = "pb_img_francisco_c_aboutControl";
            pb_img_francisco_c_aboutControl.Size = new Size(75, 69);
            pb_img_francisco_c_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img_francisco_c_aboutControl.TabIndex = 0;
            pb_img_francisco_c_aboutControl.TabStop = false;
            pb_img_francisco_c_aboutControl.Click += pb_img_francisco_c_aboutControl_Click_1;
            // 
            // pb_img_diego_aboutControl
            // 
            pb_img_diego_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_img_diego_aboutControl.Image = (Image)resources.GetObject("pb_img_diego_aboutControl.Image");
            pb_img_diego_aboutControl.Location = new Point(158, 97);
            pb_img_diego_aboutControl.Name = "pb_img_diego_aboutControl";
            pb_img_diego_aboutControl.Size = new Size(75, 69);
            pb_img_diego_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img_diego_aboutControl.TabIndex = 0;
            pb_img_diego_aboutControl.TabStop = false;
            pb_img_diego_aboutControl.Click += pb_img_diego_aboutControl_Click_1;
            // 
            // pb_img_chanel_aboutControl
            // 
            pb_img_chanel_aboutControl.BackColor = Color.FromArgb(237, 230, 219);
            pb_img_chanel_aboutControl.Image = (Image)resources.GetObject("pb_img_chanel_aboutControl.Image");
            pb_img_chanel_aboutControl.Location = new Point(30, 97);
            pb_img_chanel_aboutControl.Name = "pb_img_chanel_aboutControl";
            pb_img_chanel_aboutControl.Size = new Size(75, 69);
            pb_img_chanel_aboutControl.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_img_chanel_aboutControl.TabIndex = 0;
            pb_img_chanel_aboutControl.TabStop = false;
            pb_img_chanel_aboutControl.Click += pb_img_chanel_aboutControl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_about_btnClose;
            pictureBox1.Location = new Point(357, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 230, 219);
            Controls.Add(pictureBox1);
            Controls.Add(pb_img_chanel_aboutControl);
            Controls.Add(pb_img_diego_aboutControl);
            Controls.Add(pb_img_francisco_c_aboutControl);
            Controls.Add(pb_img_francisco_a_aboutControl);
            Controls.Add(pb_img_steven_aboutControl);
            Controls.Add(pb_name_aboutControl);
            Controls.Add(lbl_chanel_aboutControl);
            Controls.Add(lbl_diego_aboutControl);
            Controls.Add(lbl_francisco_c_aboutControl);
            Controls.Add(lbl_francisco_a_aboutControl);
            Controls.Add(lbl_steven_aboutControl);
            Location = new Point(683, 15);
            Name = "AboutControl";
            Size = new Size(405, 367);
            Paint += AboutControl_Paint;
            ((System.ComponentModel.ISupportInitialize)pb_name_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_steven_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_francisco_a_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_francisco_c_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_diego_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_img_chanel_aboutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pb_name_aboutControl;
        private Label lbl_steven_aboutControl;
        private Label lbl_francisco_a_aboutControl;
        private Label lbl_francisco_c_aboutControl;
        private Label lbl_diego_aboutControl;
        private Label lbl_chanel_aboutControl;
        private PictureBox pb_img_steven_aboutControl;
        private PictureBox pb_img_francisco_a_aboutControl;
        private PictureBox pb_img_francisco_c_aboutControl;
        private PictureBox pb_img_diego_aboutControl;
        private PictureBox pb_img_chanel_aboutControl;
        private PictureBox pictureBox1;
    }
}
