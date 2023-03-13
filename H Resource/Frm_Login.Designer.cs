namespace H_Resource
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            BElipse_Form_Login = new Bunifu.Framework.UI.BunifuElipse(components);
            Pib_Img_HomeLogin = new PictureBox();
            BImgBtn_Btn_Close = new Bunifu.UI.WinForms.BunifuImageButton();
            Lbl_User = new Label();
            Lbl_Password = new Label();
            Pib_Backgound_txt = new PictureBox();
            Pib_Bacground_Btn_Login = new PictureBox();
            Txt_User = new TextBox();
            Txt_Password = new TextBox();
            BflatBtn_Btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)Pib_Img_HomeLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pib_Backgound_txt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pib_Bacground_Btn_Login).BeginInit();
            SuspendLayout();
            // 
            // BElipse_Form_Login
            // 
            BElipse_Form_Login.ElipseRadius = 15;
            BElipse_Form_Login.TargetControl = this;
            // 
            // Pib_Img_HomeLogin
            // 
            Pib_Img_HomeLogin.Image = (Image)resources.GetObject("Pib_Img_HomeLogin.Image");
            Pib_Img_HomeLogin.Location = new Point(38, 28);
            Pib_Img_HomeLogin.Name = "Pib_Img_HomeLogin";
            Pib_Img_HomeLogin.Size = new Size(365, 430);
            Pib_Img_HomeLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            Pib_Img_HomeLogin.TabIndex = 0;
            Pib_Img_HomeLogin.TabStop = false;
            // 
            // BImgBtn_Btn_Close
            // 
            BImgBtn_Btn_Close.ActiveImage = null;
            BImgBtn_Btn_Close.AllowAnimations = true;
            BImgBtn_Btn_Close.AllowBuffering = false;
            BImgBtn_Btn_Close.AllowToggling = false;
            BImgBtn_Btn_Close.AllowZooming = true;
            BImgBtn_Btn_Close.AllowZoomingOnFocus = false;
            BImgBtn_Btn_Close.BackColor = Color.Transparent;
            BImgBtn_Btn_Close.Cursor = Cursors.Hand;
            BImgBtn_Btn_Close.DialogResult = DialogResult.None;
            BImgBtn_Btn_Close.ErrorImage = (Image)resources.GetObject("BImgBtn_Btn_Close.ErrorImage");
            BImgBtn_Btn_Close.FadeWhenInactive = false;
            BImgBtn_Btn_Close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            BImgBtn_Btn_Close.Image = (Image)resources.GetObject("BImgBtn_Btn_Close.Image");
            BImgBtn_Btn_Close.ImageActive = null;
            BImgBtn_Btn_Close.ImageLocation = null;
            BImgBtn_Btn_Close.ImageMargin = 20;
            BImgBtn_Btn_Close.ImageSize = new Size(30, 30);
            BImgBtn_Btn_Close.ImageZoomSize = new Size(50, 50);
            BImgBtn_Btn_Close.InitialImage = (Image)resources.GetObject("BImgBtn_Btn_Close.InitialImage");
            BImgBtn_Btn_Close.Location = new Point(883, 12);
            BImgBtn_Btn_Close.Name = "BImgBtn_Btn_Close";
            BImgBtn_Btn_Close.Rotation = 0;
            BImgBtn_Btn_Close.ShowActiveImage = true;
            BImgBtn_Btn_Close.ShowCursorChanges = true;
            BImgBtn_Btn_Close.ShowImageBorders = true;
            BImgBtn_Btn_Close.ShowSizeMarkers = false;
            BImgBtn_Btn_Close.Size = new Size(50, 50);
            BImgBtn_Btn_Close.TabIndex = 1;
            BImgBtn_Btn_Close.ToolTipText = "";
            BImgBtn_Btn_Close.WaitOnLoad = false;
            BImgBtn_Btn_Close.Zoom = 20;
            BImgBtn_Btn_Close.ZoomSpeed = 10;
            // 
            // Lbl_User
            // 
            Lbl_User.AutoSize = true;
            Lbl_User.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_User.ForeColor = Color.FromArgb(37, 37, 37);
            Lbl_User.Location = new Point(544, 105);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(69, 23);
            Lbl_User.TabIndex = 2;
            Lbl_User.Text = "Usuario";
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Password.ForeColor = Color.FromArgb(37, 37, 37);
            Lbl_Password.Location = new Point(544, 219);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(98, 23);
            Lbl_Password.TabIndex = 3;
            Lbl_Password.Text = "Contraseña";
            // 
            // Pib_Backgound_txt
            // 
            Pib_Backgound_txt.Image = (Image)resources.GetObject("Pib_Backgound_txt.Image");
            Pib_Backgound_txt.Location = new Point(544, 131);
            Pib_Backgound_txt.Name = "Pib_Backgound_txt";
            Pib_Backgound_txt.Size = new Size(281, 50);
            Pib_Backgound_txt.SizeMode = PictureBoxSizeMode.StretchImage;
            Pib_Backgound_txt.TabIndex = 4;
            Pib_Backgound_txt.TabStop = false;
            // 
            // Pib_Bacground_Btn_Login
            // 
            Pib_Bacground_Btn_Login.Image = (Image)resources.GetObject("Pib_Bacground_Btn_Login.Image");
            Pib_Bacground_Btn_Login.Location = new Point(544, 245);
            Pib_Bacground_Btn_Login.Name = "Pib_Bacground_Btn_Login";
            Pib_Bacground_Btn_Login.Size = new Size(281, 50);
            Pib_Bacground_Btn_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            Pib_Bacground_Btn_Login.TabIndex = 5;
            Pib_Bacground_Btn_Login.TabStop = false;
            // 
            // Txt_User
            // 
            Txt_User.BackColor = Color.FromArgb(244, 251, 247);
            Txt_User.BorderStyle = BorderStyle.None;
            Txt_User.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_User.Location = new Point(555, 148);
            Txt_User.Name = "Txt_User";
            Txt_User.Size = new Size(255, 18);
            Txt_User.TabIndex = 6;
            // 
            // Txt_Password
            // 
            Txt_Password.BackColor = Color.FromArgb(244, 251, 247);
            Txt_Password.BorderStyle = BorderStyle.None;
            Txt_Password.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Password.Location = new Point(555, 262);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(255, 18);
            Txt_Password.TabIndex = 7;
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // BflatBtn_Btn_Login
            // 
            BflatBtn_Btn_Login.Active = false;
            BflatBtn_Btn_Login.Activecolor = Color.Transparent;
            BflatBtn_Btn_Login.BackColor = Color.Transparent;
            BflatBtn_Btn_Login.BackgroundImage = (Image)resources.GetObject("BflatBtn_Btn_Login.BackgroundImage");
            BflatBtn_Btn_Login.BackgroundImageLayout = ImageLayout.Stretch;
            BflatBtn_Btn_Login.BorderRadius = 0;
            BflatBtn_Btn_Login.ButtonText = "Iniciar sesión";
            BflatBtn_Btn_Login.DisabledColor = Color.Gray;
            BflatBtn_Btn_Login.Iconcolor = Color.Transparent;
            BflatBtn_Btn_Login.Iconimage = null;
            BflatBtn_Btn_Login.Iconimage_right = null;
            BflatBtn_Btn_Login.Iconimage_right_Selected = null;
            BflatBtn_Btn_Login.Iconimage_Selected = null;
            BflatBtn_Btn_Login.IconMarginLeft = 0;
            BflatBtn_Btn_Login.IconMarginRight = 0;
            BflatBtn_Btn_Login.IconRightVisible = true;
            BflatBtn_Btn_Login.IconRightZoom = 0D;
            BflatBtn_Btn_Login.IconVisible = true;
            BflatBtn_Btn_Login.IconZoom = 90D;
            BflatBtn_Btn_Login.IsTab = false;
            BflatBtn_Btn_Login.Location = new Point(544, 334);
            BflatBtn_Btn_Login.Margin = new Padding(4, 3, 4, 3);
            BflatBtn_Btn_Login.Name = "BflatBtn_Btn_Login";
            BflatBtn_Btn_Login.Normalcolor = Color.Transparent;
            BflatBtn_Btn_Login.OnHovercolor = Color.Transparent;
            BflatBtn_Btn_Login.OnHoverTextColor = Color.FromArgb(237, 230, 219);
            BflatBtn_Btn_Login.selected = false;
            BflatBtn_Btn_Login.Size = new Size(281, 62);
            BflatBtn_Btn_Login.TabIndex = 8;
            BflatBtn_Btn_Login.Text = "Iniciar sesión";
            BflatBtn_Btn_Login.TextAlign = ContentAlignment.MiddleCenter;
            BflatBtn_Btn_Login.Textcolor = Color.FromArgb(26, 60, 64);
            BflatBtn_Btn_Login.TextFont = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 230, 219);
            ClientSize = new Size(945, 489);
            Controls.Add(BflatBtn_Btn_Login);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_User);
            Controls.Add(Pib_Bacground_Btn_Login);
            Controls.Add(Pib_Backgound_txt);
            Controls.Add(Lbl_Password);
            Controls.Add(Lbl_User);
            Controls.Add(BImgBtn_Btn_Close);
            Controls.Add(Pib_Img_HomeLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Pib_Img_HomeLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pib_Backgound_txt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pib_Bacground_Btn_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BElipse_Form_Login;
        private PictureBox Pib_Img_HomeLogin;
        private PictureBox Pib_Bacground_Btn_Login;
        private PictureBox Pib_Backgound_txt;
        private Label Lbl_Password;
        private Label Lbl_User;
        private Bunifu.UI.WinForms.BunifuImageButton BImgBtn_Btn_Close;
        private TextBox Txt_Password;
        private TextBox Txt_User;
        private Bunifu.Framework.UI.BunifuFlatButton BflatBtn_Btn_Login;
    }
}