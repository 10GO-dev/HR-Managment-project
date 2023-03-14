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
            panel1 = new Panel();
            pb_btnClose = new PictureBox();
            pb_btnLogin = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 230, 219);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(pb_btnClose);
            panel1.Controls.Add(pb_btnLogin);
            panel1.Controls.Add(pictureBox3);
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
            // pb_btnClose
            // 
            pb_btnClose.Image = Properties.Resources.Icon_Close_Btn;
            pb_btnClose.Location = new Point(891, 12);
            pb_btnClose.Name = "pb_btnClose";
            pb_btnClose.Size = new Size(41, 41);
            pb_btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_btnClose.TabIndex = 10;
            pb_btnClose.TabStop = false;
            pb_btnClose.Click += pb_btnClose_Click;
            // 
            // pb_btnLogin
            // 
            pb_btnLogin.Image = Properties.Resources.Img_Background_btn_Login;
            pb_btnLogin.Location = new Point(556, 339);
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
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Img_HomeLogo;
            pictureBox3.Location = new Point(27, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(398, 430);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Img_Background_txt;
            pictureBox1.Location = new Point(556, 113);
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
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(568, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 19);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 37, 37);
            label1.Location = new Point(556, 87);
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
            textBox1.Location = new Point(567, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 18);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(37, 37, 37);
            label2.Location = new Point(556, 201);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Img_Background_txt;
            pictureBox2.Location = new Point(556, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(244, 251, 247);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(569, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 22);
            textBox3.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 489);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            Paint += LoginForm_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pb_btnLogin;
        private PictureBox pb_btnClose;
        private TextBox textBox3;
    }
}