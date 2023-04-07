namespace H_Resource.Views
{
    partial class AddEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeView));
            Pb_backgound_New = new PictureBox();
            Lbl_New = new Label();
            Pb_btnConfirmar = new PictureBox();
            Pb_btnAtras = new PictureBox();
            Pb_imgPerfil = new PictureBox();
            Pb_btn_AddAvatar = new PictureBox();
            Lbl_Name = new Label();
            Txt_Name = new TextBox();
            Pn_Name = new Panel();
            Pn_LastName = new Panel();
            Txt_LastName = new TextBox();
            Lbl_LastName = new Label();
            Pn_Email = new Panel();
            Txt_Email = new TextBox();
            Lbl_Email = new Label();
            Pn_Address = new Panel();
            Txt_Address = new TextBox();
            Lbl_Address = new Label();
            Pn_Nationality = new Panel();
            Txt_Nationality = new TextBox();
            Lbl_Nationaliy = new Label();
            Pn_Idcard = new Panel();
            Txt_idcard = new TextBox();
            Lbl_Idcard = new Label();
            Pn_Phone = new Panel();
            Txt_Phone = new TextBox();
            Lbl_Phone = new Label();
            Lbl_Dateofhire = new Label();
            Lbl_Birthdate = new Label();
            Dtp_Dateofhire = new DateTimePicker();
            Dtp_Birthdate = new DateTimePicker();
            Pn_Salary = new Panel();
            Txt_Salary = new TextBox();
            Lbl_Salary = new Label();
            Cmbox_Department = new ComboBox();
            Lbl_Department = new Label();
            Cb_Gender = new ComboBox();
            Lb_Genero = new Label();
            ((System.ComponentModel.ISupportInitialize)Pb_backgound_New).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_AddAvatar).BeginInit();
            Pn_Name.SuspendLayout();
            Pn_LastName.SuspendLayout();
            Pn_Email.SuspendLayout();
            Pn_Address.SuspendLayout();
            Pn_Nationality.SuspendLayout();
            Pn_Idcard.SuspendLayout();
            Pn_Phone.SuspendLayout();
            Pn_Salary.SuspendLayout();
            SuspendLayout();
            // 
            // Pb_backgound_New
            // 
            Pb_backgound_New.BackColor = Color.FromArgb(237, 230, 219);
            Pb_backgound_New.Location = new Point(35, 46);
            Pb_backgound_New.Name = "Pb_backgound_New";
            Pb_backgound_New.Size = new Size(779, 425);
            Pb_backgound_New.TabIndex = 0;
            Pb_backgound_New.TabStop = false;
            // 
            // Lbl_New
            // 
            Lbl_New.AutoSize = true;
            Lbl_New.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_New.ForeColor = Color.FromArgb(237, 230, 219);
            Lbl_New.Location = new Point(364, 11);
            Lbl_New.Name = "Lbl_New";
            Lbl_New.Size = new Size(124, 23);
            Lbl_New.TabIndex = 1;
            Lbl_New.Text = "Agregar Nuevo";
            // 
            // Pb_btnConfirmar
            // 
            Pb_btnConfirmar.Cursor = Cursors.Hand;
            Pb_btnConfirmar.Image = Properties.Resources.Img_Btn_Comfirm;
            Pb_btnConfirmar.Location = new Point(704, 21);
            Pb_btnConfirmar.Name = "Pb_btnConfirmar";
            Pb_btnConfirmar.Size = new Size(110, 18);
            Pb_btnConfirmar.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btnConfirmar.TabIndex = 2;
            Pb_btnConfirmar.TabStop = false;
            Pb_btnConfirmar.Click += Pb_btnConfirmar_Click;
            // 
            // Pb_btnAtras
            // 
            Pb_btnAtras.Cursor = Cursors.Hand;
            Pb_btnAtras.Image = Properties.Resources.Img_Btn_Back;
            Pb_btnAtras.Location = new Point(35, 21);
            Pb_btnAtras.Name = "Pb_btnAtras";
            Pb_btnAtras.Size = new Size(72, 18);
            Pb_btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btnAtras.TabIndex = 3;
            Pb_btnAtras.TabStop = false;
            // 
            // Pb_imgPerfil
            // 
            Pb_imgPerfil.BackColor = Color.FromArgb(237, 230, 219);
            Pb_imgPerfil.Image = Properties.Resources.Img_Avatar;
            Pb_imgPerfil.Location = new Point(404, 75);
            Pb_imgPerfil.Name = "Pb_imgPerfil";
            Pb_imgPerfil.Size = new Size(50, 50);
            Pb_imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_imgPerfil.TabIndex = 4;
            Pb_imgPerfil.TabStop = false;
            Pb_imgPerfil.Paint += Pb_imgPerfil_Paint;
            // 
            // Pb_btn_AddAvatar
            // 
            Pb_btn_AddAvatar.Cursor = Cursors.Hand;
            Pb_btn_AddAvatar.Image = (Image)resources.GetObject("Pb_btn_AddAvatar.Image");
            Pb_btn_AddAvatar.Location = new Point(446, 115);
            Pb_btn_AddAvatar.Name = "Pb_btn_AddAvatar";
            Pb_btn_AddAvatar.Size = new Size(16, 16);
            Pb_btn_AddAvatar.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btn_AddAvatar.TabIndex = 5;
            Pb_btn_AddAvatar.TabStop = false;
            Pb_btn_AddAvatar.Click += Pb_btn_AddAvatar_Click;
            Pb_btn_AddAvatar.Paint += Pb_btn_AddAvatar_Paint;
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Name.Location = new Point(64, 78);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(64, 18);
            Lbl_Name.TabIndex = 6;
            Lbl_Name.Text = "Nombre";
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Name.BorderStyle = BorderStyle.None;
            Txt_Name.Location = new Point(3, 8);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(230, 16);
            Txt_Name.TabIndex = 7;
            // 
            // Pn_Name
            // 
            Pn_Name.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Name.BackgroundImage = (Image)resources.GetObject("Pn_Name.BackgroundImage");
            Pn_Name.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Name.Controls.Add(Txt_Name);
            Pn_Name.Location = new Point(64, 101);
            Pn_Name.Name = "Pn_Name";
            Pn_Name.Size = new Size(236, 31);
            Pn_Name.TabIndex = 9;
            // 
            // Pn_LastName
            // 
            Pn_LastName.BackColor = Color.FromArgb(237, 230, 219);
            Pn_LastName.BackgroundImage = (Image)resources.GetObject("Pn_LastName.BackgroundImage");
            Pn_LastName.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_LastName.Controls.Add(Txt_LastName);
            Pn_LastName.Location = new Point(64, 158);
            Pn_LastName.Name = "Pn_LastName";
            Pn_LastName.Size = new Size(236, 31);
            Pn_LastName.TabIndex = 11;
            // 
            // Txt_LastName
            // 
            Txt_LastName.BackColor = Color.FromArgb(237, 230, 219);
            Txt_LastName.BorderStyle = BorderStyle.None;
            Txt_LastName.Location = new Point(3, 8);
            Txt_LastName.Name = "Txt_LastName";
            Txt_LastName.Size = new Size(230, 16);
            Txt_LastName.TabIndex = 7;
            // 
            // Lbl_LastName
            // 
            Lbl_LastName.AutoSize = true;
            Lbl_LastName.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_LastName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_LastName.Location = new Point(64, 135);
            Lbl_LastName.Name = "Lbl_LastName";
            Lbl_LastName.Size = new Size(65, 18);
            Lbl_LastName.TabIndex = 10;
            Lbl_LastName.Text = "Apellido";
            // 
            // Pn_Email
            // 
            Pn_Email.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Email.BackgroundImage = (Image)resources.GetObject("Pn_Email.BackgroundImage");
            Pn_Email.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Email.Controls.Add(Txt_Email);
            Pn_Email.Location = new Point(62, 215);
            Pn_Email.Name = "Pn_Email";
            Pn_Email.Size = new Size(236, 31);
            Pn_Email.TabIndex = 13;
            // 
            // Txt_Email
            // 
            Txt_Email.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Email.BorderStyle = BorderStyle.None;
            Txt_Email.Location = new Point(3, 8);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(230, 16);
            Txt_Email.TabIndex = 7;
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Email.Location = new Point(62, 192);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(137, 18);
            Lbl_Email.TabIndex = 12;
            Lbl_Email.Text = "Correo electrónico";
            // 
            // Pn_Address
            // 
            Pn_Address.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Address.BackgroundImage = (Image)resources.GetObject("Pn_Address.BackgroundImage");
            Pn_Address.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Address.Controls.Add(Txt_Address);
            Pn_Address.Location = new Point(62, 272);
            Pn_Address.Name = "Pn_Address";
            Pn_Address.Size = new Size(236, 31);
            Pn_Address.TabIndex = 15;
            // 
            // Txt_Address
            // 
            Txt_Address.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Address.BorderStyle = BorderStyle.None;
            Txt_Address.Location = new Point(3, 8);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(230, 16);
            Txt_Address.TabIndex = 7;
            // 
            // Lbl_Address
            // 
            Lbl_Address.AutoSize = true;
            Lbl_Address.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Address.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Address.Location = new Point(62, 249);
            Lbl_Address.Name = "Lbl_Address";
            Lbl_Address.Size = new Size(75, 18);
            Lbl_Address.TabIndex = 14;
            Lbl_Address.Text = "Dirección";
            // 
            // Pn_Nationality
            // 
            Pn_Nationality.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Nationality.BackgroundImage = (Image)resources.GetObject("Pn_Nationality.BackgroundImage");
            Pn_Nationality.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Nationality.Controls.Add(Txt_Nationality);
            Pn_Nationality.Location = new Point(540, 101);
            Pn_Nationality.Name = "Pn_Nationality";
            Pn_Nationality.Size = new Size(236, 31);
            Pn_Nationality.TabIndex = 17;
            // 
            // Txt_Nationality
            // 
            Txt_Nationality.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Nationality.BorderStyle = BorderStyle.None;
            Txt_Nationality.Location = new Point(3, 8);
            Txt_Nationality.Name = "Txt_Nationality";
            Txt_Nationality.Size = new Size(230, 16);
            Txt_Nationality.TabIndex = 7;
            // 
            // Lbl_Nationaliy
            // 
            Lbl_Nationaliy.AutoSize = true;
            Lbl_Nationaliy.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Nationaliy.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Nationaliy.Location = new Point(540, 78);
            Lbl_Nationaliy.Name = "Lbl_Nationaliy";
            Lbl_Nationaliy.Size = new Size(100, 18);
            Lbl_Nationaliy.TabIndex = 16;
            Lbl_Nationaliy.Text = "Nacionalidad";
            // 
            // Pn_Idcard
            // 
            Pn_Idcard.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Idcard.BackgroundImage = (Image)resources.GetObject("Pn_Idcard.BackgroundImage");
            Pn_Idcard.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Idcard.Controls.Add(Txt_idcard);
            Pn_Idcard.Location = new Point(540, 158);
            Pn_Idcard.Name = "Pn_Idcard";
            Pn_Idcard.Size = new Size(236, 31);
            Pn_Idcard.TabIndex = 19;
            // 
            // Txt_idcard
            // 
            Txt_idcard.BackColor = Color.FromArgb(237, 230, 219);
            Txt_idcard.BorderStyle = BorderStyle.None;
            Txt_idcard.Location = new Point(3, 8);
            Txt_idcard.MaxLength = 11;
            Txt_idcard.Name = "Txt_idcard";
            Txt_idcard.Size = new Size(230, 16);
            Txt_idcard.TabIndex = 7;
            Txt_idcard.KeyPress += Txt_idcard_KeyPress;
            // 
            // Lbl_Idcard
            // 
            Lbl_Idcard.AutoSize = true;
            Lbl_Idcard.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Idcard.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Idcard.Location = new Point(540, 135);
            Lbl_Idcard.Name = "Lbl_Idcard";
            Lbl_Idcard.Size = new Size(58, 18);
            Lbl_Idcard.TabIndex = 18;
            Lbl_Idcard.Text = "Cedula";
            // 
            // Pn_Phone
            // 
            Pn_Phone.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Phone.BackgroundImage = (Image)resources.GetObject("Pn_Phone.BackgroundImage");
            Pn_Phone.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Phone.Controls.Add(Txt_Phone);
            Pn_Phone.Location = new Point(540, 215);
            Pn_Phone.Name = "Pn_Phone";
            Pn_Phone.Size = new Size(236, 31);
            Pn_Phone.TabIndex = 21;
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Phone.BorderStyle = BorderStyle.None;
            Txt_Phone.Location = new Point(3, 8);
            Txt_Phone.MaxLength = 10;
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(230, 16);
            Txt_Phone.TabIndex = 7;
            Txt_Phone.KeyPress += Txt_Phone_KeyPress;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.AutoSize = true;
            Lbl_Phone.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Phone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Phone.Location = new Point(540, 192);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(66, 18);
            Lbl_Phone.TabIndex = 20;
            Lbl_Phone.Text = "Teléfono";
            // 
            // Lbl_Dateofhire
            // 
            Lbl_Dateofhire.AutoSize = true;
            Lbl_Dateofhire.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Dateofhire.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Dateofhire.Location = new Point(67, 321);
            Lbl_Dateofhire.Name = "Lbl_Dateofhire";
            Lbl_Dateofhire.Size = new Size(154, 18);
            Lbl_Dateofhire.TabIndex = 22;
            Lbl_Dateofhire.Text = "Fecha de nacimiento";
            // 
            // Lbl_Birthdate
            // 
            Lbl_Birthdate.AutoSize = true;
            Lbl_Birthdate.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Birthdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Birthdate.Location = new Point(67, 380);
            Lbl_Birthdate.Name = "Lbl_Birthdate";
            Lbl_Birthdate.Size = new Size(163, 18);
            Lbl_Birthdate.TabIndex = 23;
            Lbl_Birthdate.Text = "Fecha de contratación";
            // 
            // Dtp_Dateofhire
            // 
            Dtp_Dateofhire.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Dateofhire.Format = DateTimePickerFormat.Short;
            Dtp_Dateofhire.Location = new Point(67, 347);
            Dtp_Dateofhire.Name = "Dtp_Dateofhire";
            Dtp_Dateofhire.Size = new Size(154, 23);
            Dtp_Dateofhire.TabIndex = 24;
            // 
            // Dtp_Birthdate
            // 
            Dtp_Birthdate.CalendarForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTitleBackColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTitleForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTrailingForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.Format = DateTimePickerFormat.Short;
            Dtp_Birthdate.Location = new Point(67, 403);
            Dtp_Birthdate.Name = "Dtp_Birthdate";
            Dtp_Birthdate.Size = new Size(154, 23);
            Dtp_Birthdate.TabIndex = 25;
            // 
            // Pn_Salary
            // 
            Pn_Salary.BackColor = Color.FromArgb(237, 230, 219);
            Pn_Salary.BackgroundImage = (Image)resources.GetObject("Pn_Salary.BackgroundImage");
            Pn_Salary.BackgroundImageLayout = ImageLayout.Stretch;
            Pn_Salary.Controls.Add(Txt_Salary);
            Pn_Salary.Location = new Point(540, 272);
            Pn_Salary.Name = "Pn_Salary";
            Pn_Salary.Size = new Size(236, 31);
            Pn_Salary.TabIndex = 27;
            // 
            // Txt_Salary
            // 
            Txt_Salary.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Salary.BorderStyle = BorderStyle.None;
            Txt_Salary.Location = new Point(3, 8);
            Txt_Salary.Name = "Txt_Salary";
            Txt_Salary.Size = new Size(230, 16);
            Txt_Salary.TabIndex = 7;
            Txt_Salary.KeyPress += Txt_Salary_KeyPress;
            // 
            // Lbl_Salary
            // 
            Lbl_Salary.AutoSize = true;
            Lbl_Salary.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Salary.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Salary.Location = new Point(540, 249);
            Lbl_Salary.Name = "Lbl_Salary";
            Lbl_Salary.Size = new Size(58, 18);
            Lbl_Salary.TabIndex = 26;
            Lbl_Salary.Text = "Salario";
            // 
            // Cmbox_Department
            // 
            Cmbox_Department.BackColor = Color.FromArgb(237, 230, 219);
            Cmbox_Department.FlatStyle = FlatStyle.Flat;
            Cmbox_Department.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cmbox_Department.Items.AddRange(new object[] { "Finanzas ", "Recursos Humanos ", "Logistica ", "Tecnologico ", "Publicidad" });
            Cmbox_Department.Location = new Point(540, 412);
            Cmbox_Department.Name = "Cmbox_Department";
            Cmbox_Department.Size = new Size(236, 29);
            Cmbox_Department.TabIndex = 28;
            Cmbox_Department.KeyPress += Cmbox_Department_KeyPress;
            // 
            // Lbl_Department
            // 
            Lbl_Department.AutoSize = true;
            Lbl_Department.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Department.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Department.Location = new Point(540, 384);
            Lbl_Department.Name = "Lbl_Department";
            Lbl_Department.Size = new Size(108, 18);
            Lbl_Department.TabIndex = 29;
            Lbl_Department.Text = "Departamento";
            // 
            // Cb_Gender
            // 
            Cb_Gender.BackColor = Color.FromArgb(237, 230, 219);
            Cb_Gender.FlatStyle = FlatStyle.Flat;
            Cb_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cb_Gender.Items.AddRange(new object[] { "Masculino", "Femenino" });
            Cb_Gender.Location = new Point(540, 341);
            Cb_Gender.Name = "Cb_Gender";
            Cb_Gender.Size = new Size(236, 29);
            Cb_Gender.TabIndex = 30;
            // 
            // Lb_Genero
            // 
            Lb_Genero.AutoSize = true;
            Lb_Genero.BackColor = Color.FromArgb(237, 230, 219);
            Lb_Genero.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lb_Genero.Location = new Point(540, 313);
            Lb_Genero.Name = "Lb_Genero";
            Lb_Genero.Size = new Size(60, 18);
            Lb_Genero.TabIndex = 31;
            Lb_Genero.Text = "Género";
            // 
            // NewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 92, 99);
            ClientSize = new Size(853, 483);
            Controls.Add(Lb_Genero);
            Controls.Add(Cb_Gender);
            Controls.Add(Lbl_Department);
            Controls.Add(Cmbox_Department);
            Controls.Add(Pn_Salary);
            Controls.Add(Lbl_Salary);
            Controls.Add(Dtp_Birthdate);
            Controls.Add(Dtp_Dateofhire);
            Controls.Add(Lbl_Birthdate);
            Controls.Add(Lbl_Dateofhire);
            Controls.Add(Pn_Phone);
            Controls.Add(Lbl_Phone);
            Controls.Add(Pn_Idcard);
            Controls.Add(Lbl_Idcard);
            Controls.Add(Pn_Nationality);
            Controls.Add(Lbl_Nationaliy);
            Controls.Add(Pn_Address);
            Controls.Add(Lbl_Address);
            Controls.Add(Pn_Email);
            Controls.Add(Lbl_Email);
            Controls.Add(Pn_LastName);
            Controls.Add(Lbl_LastName);
            Controls.Add(Pn_Name);
            Controls.Add(Lbl_Name);
            Controls.Add(Pb_btn_AddAvatar);
            Controls.Add(Pb_imgPerfil);
            Controls.Add(Pb_btnAtras);
            Controls.Add(Pb_btnConfirmar);
            Controls.Add(Lbl_New);
            Controls.Add(Pb_backgound_New);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewEmployeeForm";
            Paint += NewEmployeeForm_Paint;
            ((System.ComponentModel.ISupportInitialize)Pb_backgound_New).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_AddAvatar).EndInit();
            Pn_Name.ResumeLayout(false);
            Pn_Name.PerformLayout();
            Pn_LastName.ResumeLayout(false);
            Pn_LastName.PerformLayout();
            Pn_Email.ResumeLayout(false);
            Pn_Email.PerformLayout();
            Pn_Address.ResumeLayout(false);
            Pn_Address.PerformLayout();
            Pn_Nationality.ResumeLayout(false);
            Pn_Nationality.PerformLayout();
            Pn_Idcard.ResumeLayout(false);
            Pn_Idcard.PerformLayout();
            Pn_Phone.ResumeLayout(false);
            Pn_Phone.PerformLayout();
            Pn_Salary.ResumeLayout(false);
            Pn_Salary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pb_backgound_New;
        private Label Lbl_New;
        private PictureBox Pb_btnConfirmar;
        private PictureBox Pb_btnAtras;
        private PictureBox Pb_imgPerfil;
        private PictureBox Pb_btn_AddAvatar;
        private Label Lbl_Name;
        private TextBox Txt_Name;
        private Panel Pn_Name;
        private Panel Pn_LastName;
        private TextBox Txt_LastName;
        private Label Lbl_LastName;
        private Panel Pn_Email;
        private TextBox Txt_Email;
        private Label Lbl_Email;
        private Panel Pn_Address;
        private TextBox Txt_Address;
        private Label Lbl_Address;
        private Panel Pn_Nationality;
        private TextBox Txt_Nationality;
        private Label Lbl_Nationaliy;
        private Panel Pn_Idcard;
        private TextBox Txt_idcard;
        private Label Lbl_Idcard;
        private Panel Pn_Phone;
        private TextBox Txt_Phone;
        private Label Lbl_Phone;
        private Label Lbl_Dateofhire;
        private Label Lbl_Birthdate;
        private DateTimePicker Dtp_Dateofhire;
        private DateTimePicker Dtp_Birthdate;
        private Panel Pn_Salary;
        private TextBox Txt_Salary;
        private Label Lbl_Salary;
        private ComboBox Cmbox_Department;
        private Label Lbl_Department;
        private ComboBox Cb_Gender;
        private Label Lb_Genero;
    }
}