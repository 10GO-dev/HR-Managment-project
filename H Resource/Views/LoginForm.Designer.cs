namespace H_Resource.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pb_login_container = new Panel();
            lb_login_info = new Label();
            pb_login_Image = new PictureBox();
            pb_btnClose = new PictureBox();
            pn_drag = new Panel();
            txt_username = new TextBox();
            pb_btnLogin = new PictureBox();
            pb_txt_username = new PictureBox();
            txt_password = new TextBox();
            lb_username = new Label();
            lb_password = new Label();
            pb_txt_password = new PictureBox();
            pb_login_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_login_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_txt_username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_txt_password).BeginInit();
            SuspendLayout();
            // 
            // pb_login_container
            // 
            pb_login_container.BackColor = Color.FromArgb(237, 230, 219);
            pb_login_container.Controls.Add(lb_login_info);
            pb_login_container.Controls.Add(pb_login_Image);
            pb_login_container.Controls.Add(pb_btnClose);
            pb_login_container.Controls.Add(pn_drag);
            pb_login_container.Controls.Add(txt_username);
            pb_login_container.Controls.Add(pb_btnLogin);
            pb_login_container.Controls.Add(pb_txt_username);
            pb_login_container.Controls.Add(txt_password);
            pb_login_container.Controls.Add(lb_username);
            pb_login_container.Controls.Add(lb_password);
            pb_login_container.Controls.Add(pb_txt_password);
            pb_login_container.Dock = DockStyle.Fill;
            pb_login_container.Location = new Point(0, 0);
            pb_login_container.Name = "pb_login_container";
            pb_login_container.Size = new Size(945, 489);
            pb_login_container.TabIndex = 0;
            // 
            // lb_login_info
            // 
            lb_login_info.AutoSize = true;
            lb_login_info.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_login_info.ForeColor = Color.Red;
            lb_login_info.Location = new Point(534, 303);
            lb_login_info.Name = "lb_login_info";
            lb_login_info.Size = new Size(0, 16);
            lb_login_info.TabIndex = 13;
            // 
            // pb_login_Image
            // 
            pb_login_Image.Image = Properties.Resources.Img_HomeLogo;
            pb_login_Image.Location = new Point(27, 31);
            pb_login_Image.Name = "pb_login_Image";
            pb_login_Image.Size = new Size(398, 430);
            pb_login_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_login_Image.TabIndex = 8;
            pb_login_Image.TabStop = false;
            // 
            // pb_btnClose
            // 
            pb_btnClose.Image = Properties.Resources.Icon_Close_Btn;
            pb_btnClose.Location = new Point(889, 20);
            pb_btnClose.Name = "pb_btnClose";
            pb_btnClose.Size = new Size(33, 33);
            pb_btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnClose.TabIndex = 10;
            pb_btnClose.TabStop = false;
            pb_btnClose.Click += pb_btnClose_Click;
            pb_btnClose.MouseEnter += pb_btnClose_MouseEnter;
            pb_btnClose.MouseLeave += pb_btnClose_MouseLeave;
            // 
            // pn_drag
            // 
            pn_drag.Location = new Point(-1, -1);
            pn_drag.Name = "pn_drag";
            pn_drag.Size = new Size(945, 63);
            pn_drag.TabIndex = 12;
            pn_drag.MouseDown += pn_drag_MouseDown;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(244, 251, 247);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(543, 136);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(255, 22);
            txt_username.TabIndex = 11;
            txt_username.Enter += field_click;
            txt_username.Leave += field_Leave;
            // 
            // pb_btnLogin
            // 
            pb_btnLogin.Image = Properties.Resources.Img_Background_btn_Login;
            pb_btnLogin.Location = new Point(530, 329);
            pb_btnLogin.Name = "pb_btnLogin";
            pb_btnLogin.Size = new Size(281, 58);
            pb_btnLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnLogin.TabIndex = 9;
            pb_btnLogin.TabStop = false;
            pb_btnLogin.Click += pb_btnLogin_Click;
            pb_btnLogin.MouseEnter += pb_btnLogin_MouseEnter;
            pb_btnLogin.MouseLeave += pb_btnLogin_MouseLeave;
            // 
            // pb_txt_username
            // 
            pb_txt_username.Image = Properties.Resources.Img_Background_txt;
            pb_txt_username.Location = new Point(530, 121);
            pb_txt_username.Name = "pb_txt_username";
            pb_txt_username.Size = new Size(281, 50);
            pb_txt_username.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_txt_username.TabIndex = 4;
            pb_txt_username.TabStop = false;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(244, 251, 247);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(542, 250);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(255, 22);
            txt_password.TabIndex = 7;
            txt_password.UseSystemPasswordChar = true;
            txt_password.Enter += field_click;
            txt_password.Leave += field_Leave;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.ForeColor = Color.FromArgb(40, 40, 40);
            lb_username.Location = new Point(530, 95);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(69, 23);
            lb_username.TabIndex = 2;
            lb_username.Text = "Usuario";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_password.ForeColor = Color.FromArgb(40, 40, 40);
            lb_password.Location = new Point(530, 209);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(98, 23);
            lb_password.TabIndex = 3;
            lb_password.Text = "Contraseña";
            // 
            // pb_txt_password
            // 
            pb_txt_password.Image = Properties.Resources.Img_Background_txt;
            pb_txt_password.Location = new Point(530, 235);
            pb_txt_password.Name = "pb_txt_password";
            pb_txt_password.Size = new Size(281, 50);
            pb_txt_password.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_txt_password.TabIndex = 5;
            pb_txt_password.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 489);
            Controls.Add(pb_login_container);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            Paint += LoginForm_Paint;
            pb_login_container.ResumeLayout(false);
            pb_login_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_login_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_txt_username).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_txt_password).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pb_login_container;
        private PictureBox pb_txt_username;
        private TextBox txt_password;
        private Label lb_username;
        private Label lb_password;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pb_txt_password;
        private PictureBox pb_login_Image;
        private PictureBox pb_btnLogin;
        private PictureBox pb_btnClose;
        private TextBox txt_username;
        private Panel pn_drag;
        private Label lb_login_info;
    }
}