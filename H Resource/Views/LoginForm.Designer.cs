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
            panel1 = new Panel();
            lbl_login_infoError = new Label();
            pb_login_Image = new PictureBox();
            pb_btnClose = new PictureBox();
            pn_drag = new Panel();
            textBox3 = new TextBox();
            pb_btnLogin = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_login_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 230, 219);
            panel1.Controls.Add(lbl_login_infoError);
            panel1.Controls.Add(pb_login_Image);
            panel1.Controls.Add(pb_btnClose);
            panel1.Controls.Add(pn_drag);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(pb_btnLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 489);
            panel1.TabIndex = 0;
            // 
            // lbl_login_infoError
            // 
            lbl_login_infoError.AutoSize = true;
            lbl_login_infoError.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login_infoError.ForeColor = Color.Red;
            lbl_login_infoError.Location = new Point(543, 310);
            lbl_login_infoError.Name = "lbl_login_infoError";
            lbl_login_infoError.Size = new Size(0, 16);
            lbl_login_infoError.TabIndex = 13;
            lbl_login_infoError.Click += label3_Click;
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
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(244, 251, 247);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(543, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 22);
            textBox3.TabIndex = 11;
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
            pb_btnLogin.DragLeave += pb_btnLogin_DragLeave;
            pb_btnLogin.MouseEnter += pb_btnLogin_MouseEnter;
            pb_btnLogin.MouseLeave += pb_btnLogin_MouseLeave;
            pb_btnLogin.MouseHover += pb_btnLogin_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Img_Background_txt;
            pictureBox1.Location = new Point(530, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(244, 251, 247);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(542, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 22);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(530, 95);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(244, 251, 247);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(541, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 18);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(530, 209);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Img_Background_txt;
            pictureBox2.Location = new Point(530, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 489);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            Paint += LoginForm_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_login_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pb_login_Image;
        private PictureBox pb_btnLogin;
        private PictureBox pb_btnClose;
        private TextBox textBox3;
        private Panel pn_drag;
        private Label lbl_login_infoError;
    }
}