namespace H_Resource.Views
{
    partial class AddOrEditEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditEmployeeView));
            Lb_Title = new Label();
            Pb_btnConfirmar = new PictureBox();
            BtnBack_EmployeeView = new PictureBox();
            Pb_imgPerfil = new PictureBox();
            Pb_btn_AddAvatar = new PictureBox();
            Lbl_Name = new Label();
            Txt_Name = new TextBox();
            Txt_LastName = new TextBox();
            Lbl_LastName = new Label();
            Lbl_Email = new Label();
            Txt_Address = new TextBox();
            Lbl_Address = new Label();
            Lbl_Nationaliy = new Label();
            Txt_idcard = new TextBox();
            Lbl_Idcard = new Label();
            Txt_Phone = new TextBox();
            Lbl_Phone = new Label();
            Lbl_Dateofhire = new Label();
            Lbl_Birthdate = new Label();
            Dtp_Dateofhire = new DateTimePicker();
            Dtp_Birthdate = new DateTimePicker();
            Txt_Salary = new TextBox();
            Lbl_Salary = new Label();
            cb_Department = new ComboBox();
            Lbl_Department = new Label();
            Cb_Gender = new ComboBox();
            Lb_Genero = new Label();
            pn_form = new Panel();
            panel2 = new Panel();
            Txt_Email = new TextBox();
            panel1 = new Panel();
            cb_Nationality = new ComboBox();
            pn_Avatar = new Panel();
            label1 = new Label();
            Lb_id = new Label();
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnBack_EmployeeView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_AddAvatar).BeginInit();
            pn_form.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pn_Avatar.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_Title
            // 
            Lb_Title.AutoSize = true;
            Lb_Title.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Title.ForeColor = Color.FromArgb(237, 230, 219);
            Lb_Title.Location = new Point(479, 26);
            Lb_Title.Name = "Lb_Title";
            Lb_Title.Size = new Size(124, 23);
            Lb_Title.TabIndex = 1;
            Lb_Title.Text = "Agregar Nuevo";
            // 
            // Pb_btnConfirmar
            // 
            Pb_btnConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pb_btnConfirmar.Cursor = Cursors.Hand;
            Pb_btnConfirmar.Image = Properties.Resources.Img_Btn_Comfirm;
            Pb_btnConfirmar.Location = new Point(938, 31);
            Pb_btnConfirmar.Name = "Pb_btnConfirmar";
            Pb_btnConfirmar.Size = new Size(110, 18);
            Pb_btnConfirmar.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btnConfirmar.TabIndex = 2;
            Pb_btnConfirmar.TabStop = false;
            Pb_btnConfirmar.Click += Pb_btnConfirmar_Click;
            // 
            // BtnBack_EmployeeView
            // 
            BtnBack_EmployeeView.Cursor = Cursors.Hand;
            BtnBack_EmployeeView.Image = Properties.Resources.Img_Btn_Back;
            BtnBack_EmployeeView.Location = new Point(35, 31);
            BtnBack_EmployeeView.Name = "BtnBack_EmployeeView";
            BtnBack_EmployeeView.Size = new Size(72, 18);
            BtnBack_EmployeeView.SizeMode = PictureBoxSizeMode.AutoSize;
            BtnBack_EmployeeView.TabIndex = 3;
            BtnBack_EmployeeView.TabStop = false;
            // 
            // Pb_imgPerfil
            // 
            Pb_imgPerfil.BackColor = Color.FromArgb(237, 230, 219);
            Pb_imgPerfil.Image = Properties.Resources.Img_Avatar;
            Pb_imgPerfil.Location = new Point(35, 24);
            Pb_imgPerfil.Name = "Pb_imgPerfil";
            Pb_imgPerfil.Size = new Size(114, 114);
            Pb_imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_imgPerfil.TabIndex = 4;
            Pb_imgPerfil.TabStop = false;
            Pb_imgPerfil.Paint += Pb_imgPerfil_Paint;
            // 
            // Pb_btn_AddAvatar
            // 
            Pb_btn_AddAvatar.Cursor = Cursors.Hand;
            Pb_btn_AddAvatar.Image = (Image)resources.GetObject("Pb_btn_AddAvatar.Image");
            Pb_btn_AddAvatar.Location = new Point(130, 123);
            Pb_btn_AddAvatar.Name = "Pb_btn_AddAvatar";
            Pb_btn_AddAvatar.Size = new Size(24, 24);
            Pb_btn_AddAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_AddAvatar.TabIndex = 5;
            Pb_btn_AddAvatar.TabStop = false;
            Pb_btn_AddAvatar.Click += Pb_btn_AddAvatar_Click;
            Pb_btn_AddAvatar.Paint += Pb_btn_AddAvatar_Paint;
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Name.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Name.Location = new Point(34, 9);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(71, 21);
            Lbl_Name.TabIndex = 6;
            Lbl_Name.Text = "Nombre";
            // 
            // Txt_Name
            // 
            Txt_Name.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Name.BorderStyle = BorderStyle.FixedSingle;
            Txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Name.Location = new Point(31, 33);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(230, 29);
            Txt_Name.TabIndex = 0;
            // 
            // Txt_LastName
            // 
            Txt_LastName.BackColor = Color.FromArgb(237, 230, 219);
            Txt_LastName.BorderStyle = BorderStyle.FixedSingle;
            Txt_LastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_LastName.Location = new Point(31, 91);
            Txt_LastName.Name = "Txt_LastName";
            Txt_LastName.Size = new Size(230, 29);
            Txt_LastName.TabIndex = 1;
            // 
            // Lbl_LastName
            // 
            Lbl_LastName.AutoSize = true;
            Lbl_LastName.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_LastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_LastName.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_LastName.Location = new Point(33, 68);
            Lbl_LastName.Name = "Lbl_LastName";
            Lbl_LastName.Size = new Size(72, 21);
            Lbl_LastName.TabIndex = 10;
            Lbl_LastName.Text = "Apellido";
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Email.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Email.Location = new Point(34, 125);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(148, 21);
            Lbl_Email.TabIndex = 12;
            Lbl_Email.Text = "Correo electrónico";
            // 
            // Txt_Address
            // 
            Txt_Address.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Address.BorderStyle = BorderStyle.FixedSingle;
            Txt_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Address.Location = new Point(31, 205);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(230, 29);
            Txt_Address.TabIndex = 3;
            // 
            // Lbl_Address
            // 
            Lbl_Address.AutoSize = true;
            Lbl_Address.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Address.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Address.Location = new Point(33, 182);
            Lbl_Address.Name = "Lbl_Address";
            Lbl_Address.Size = new Size(79, 21);
            Lbl_Address.TabIndex = 14;
            Lbl_Address.Text = "Dirección";
            // 
            // Lbl_Nationaliy
            // 
            Lbl_Nationaliy.AutoSize = true;
            Lbl_Nationaliy.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Nationaliy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Nationaliy.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Nationaliy.Location = new Point(32, 9);
            Lbl_Nationaliy.Name = "Lbl_Nationaliy";
            Lbl_Nationaliy.Size = new Size(105, 21);
            Lbl_Nationaliy.TabIndex = 16;
            Lbl_Nationaliy.Text = "Nacionalidad";
            // 
            // Txt_idcard
            // 
            Txt_idcard.BackColor = Color.FromArgb(237, 230, 219);
            Txt_idcard.BorderStyle = BorderStyle.FixedSingle;
            Txt_idcard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_idcard.Location = new Point(28, 97);
            Txt_idcard.MaxLength = 11;
            Txt_idcard.Name = "Txt_idcard";
            Txt_idcard.Size = new Size(236, 29);
            Txt_idcard.TabIndex = 4;
            Txt_idcard.KeyPress += Txt_idcard_KeyPress;
            // 
            // Lbl_Idcard
            // 
            Lbl_Idcard.AutoSize = true;
            Lbl_Idcard.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Idcard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Idcard.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Idcard.Location = new Point(31, 73);
            Lbl_Idcard.Name = "Lbl_Idcard";
            Lbl_Idcard.Size = new Size(60, 21);
            Lbl_Idcard.TabIndex = 18;
            Lbl_Idcard.Text = "Cedula";
            // 
            // Txt_Phone
            // 
            Txt_Phone.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            Txt_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Phone.Location = new Point(28, 158);
            Txt_Phone.MaxLength = 10;
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(236, 29);
            Txt_Phone.TabIndex = 5;
            Txt_Phone.KeyPress += Txt_Phone_KeyPress;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.AutoSize = true;
            Lbl_Phone.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Phone.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Phone.Location = new Point(31, 134);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(74, 21);
            Lbl_Phone.TabIndex = 20;
            Lbl_Phone.Text = "Teléfono";
            // 
            // Lbl_Dateofhire
            // 
            Lbl_Dateofhire.AutoSize = true;
            Lbl_Dateofhire.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Dateofhire.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Dateofhire.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Dateofhire.Location = new Point(33, 256);
            Lbl_Dateofhire.Name = "Lbl_Dateofhire";
            Lbl_Dateofhire.Size = new Size(160, 21);
            Lbl_Dateofhire.TabIndex = 22;
            Lbl_Dateofhire.Text = "Fecha de nacimiento";
            // 
            // Lbl_Birthdate
            // 
            Lbl_Birthdate.AutoSize = true;
            Lbl_Birthdate.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Birthdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Birthdate.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Birthdate.Location = new Point(33, 315);
            Lbl_Birthdate.Name = "Lbl_Birthdate";
            Lbl_Birthdate.Size = new Size(171, 21);
            Lbl_Birthdate.TabIndex = 23;
            Lbl_Birthdate.Text = "Fecha de contratación";
            // 
            // Dtp_Dateofhire
            // 
            Dtp_Dateofhire.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Dateofhire.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dtp_Dateofhire.Format = DateTimePickerFormat.Short;
            Dtp_Dateofhire.Location = new Point(31, 281);
            Dtp_Dateofhire.Name = "Dtp_Dateofhire";
            Dtp_Dateofhire.Size = new Size(154, 29);
            Dtp_Dateofhire.TabIndex = 24;
            // 
            // Dtp_Birthdate
            // 
            Dtp_Birthdate.CalendarForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTitleBackColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTitleForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.CalendarTrailingForeColor = Color.FromArgb(29, 92, 99);
            Dtp_Birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dtp_Birthdate.Format = DateTimePickerFormat.Short;
            Dtp_Birthdate.Location = new Point(31, 339);
            Dtp_Birthdate.Name = "Dtp_Birthdate";
            Dtp_Birthdate.Size = new Size(154, 29);
            Dtp_Birthdate.TabIndex = 25;
            // 
            // Txt_Salary
            // 
            Txt_Salary.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Salary.BorderStyle = BorderStyle.FixedSingle;
            Txt_Salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Salary.Location = new Point(29, 219);
            Txt_Salary.Name = "Txt_Salary";
            Txt_Salary.Size = new Size(235, 29);
            Txt_Salary.TabIndex = 6;
            Txt_Salary.KeyPress += Txt_Salary_KeyPress;
            // 
            // Lbl_Salary
            // 
            Lbl_Salary.AutoSize = true;
            Lbl_Salary.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Salary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Salary.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Salary.Location = new Point(32, 195);
            Lbl_Salary.Name = "Lbl_Salary";
            Lbl_Salary.Size = new Size(59, 21);
            Lbl_Salary.TabIndex = 26;
            Lbl_Salary.Text = "Salario";
            // 
            // cb_Department
            // 
            cb_Department.BackColor = Color.FromArgb(237, 230, 219);
            cb_Department.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Department.FlatStyle = FlatStyle.Flat;
            cb_Department.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Department.Items.AddRange(new object[] { "Finanzas ", "Recursos Humanos ", "Logistica ", "Tecnologico ", "Publicidad" });
            cb_Department.Location = new Point(28, 340);
            cb_Department.Name = "cb_Department";
            cb_Department.Size = new Size(236, 29);
            cb_Department.TabIndex = 28;
            // 
            // Lbl_Department
            // 
            Lbl_Department.AutoSize = true;
            Lbl_Department.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Department.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Department.ForeColor = Color.FromArgb(26, 60, 64);
            Lbl_Department.Location = new Point(31, 316);
            Lbl_Department.Name = "Lbl_Department";
            Lbl_Department.Size = new Size(116, 21);
            Lbl_Department.TabIndex = 29;
            Lbl_Department.Text = "Departamento";
            // 
            // Cb_Gender
            // 
            Cb_Gender.BackColor = Color.FromArgb(237, 230, 219);
            Cb_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Gender.FlatStyle = FlatStyle.Flat;
            Cb_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cb_Gender.Items.AddRange(new object[] { "Masculino", "Femenino" });
            Cb_Gender.Location = new Point(28, 275);
            Cb_Gender.Name = "Cb_Gender";
            Cb_Gender.Size = new Size(236, 29);
            Cb_Gender.TabIndex = 30;
            // 
            // Lb_Genero
            // 
            Lb_Genero.AutoSize = true;
            Lb_Genero.BackColor = Color.FromArgb(237, 230, 219);
            Lb_Genero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_Genero.ForeColor = Color.FromArgb(26, 60, 64);
            Lb_Genero.Location = new Point(31, 250);
            Lb_Genero.Name = "Lb_Genero";
            Lb_Genero.Size = new Size(64, 21);
            Lb_Genero.TabIndex = 31;
            Lb_Genero.Text = "Género";
            // 
            // pn_form
            // 
            pn_form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_form.BackColor = Color.FromArgb(237, 230, 219);
            pn_form.Controls.Add(panel2);
            pn_form.Controls.Add(panel1);
            pn_form.Controls.Add(pn_Avatar);
            pn_form.Location = new Point(35, 75);
            pn_form.MaximumSize = new Size(1360, 768);
            pn_form.MinimumSize = new Size(835, 421);
            pn_form.Name = "pn_form";
            pn_form.Size = new Size(1013, 421);
            pn_form.TabIndex = 32;
            pn_form.Paint += pn_form_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(Lbl_Name);
            panel2.Controls.Add(Txt_Name);
            panel2.Controls.Add(Lbl_Address);
            panel2.Controls.Add(Lbl_Dateofhire);
            panel2.Controls.Add(Dtp_Birthdate);
            panel2.Controls.Add(Txt_Address);
            panel2.Controls.Add(Txt_LastName);
            panel2.Controls.Add(Lbl_Birthdate);
            panel2.Controls.Add(Lbl_Email);
            panel2.Controls.Add(Dtp_Dateofhire);
            panel2.Controls.Add(Txt_Email);
            panel2.Controls.Add(Lbl_LastName);
            panel2.Location = new Point(72, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 383);
            panel2.TabIndex = 35;
            // 
            // Txt_Email
            // 
            Txt_Email.BackColor = Color.FromArgb(237, 230, 219);
            Txt_Email.BorderStyle = BorderStyle.FixedSingle;
            Txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Email.Location = new Point(31, 148);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(230, 29);
            Txt_Email.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(Lbl_Nationaliy);
            panel1.Controls.Add(cb_Nationality);
            panel1.Controls.Add(Txt_idcard);
            panel1.Controls.Add(Lb_Genero);
            panel1.Controls.Add(Txt_Salary);
            panel1.Controls.Add(Lbl_Idcard);
            panel1.Controls.Add(Cb_Gender);
            panel1.Controls.Add(Txt_Phone);
            panel1.Controls.Add(Lbl_Phone);
            panel1.Controls.Add(Lbl_Department);
            panel1.Controls.Add(cb_Department);
            panel1.Controls.Add(Lbl_Salary);
            panel1.Location = new Point(639, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 383);
            panel1.TabIndex = 34;
            // 
            // cb_Nationality
            // 
            cb_Nationality.BackColor = Color.FromArgb(237, 230, 219);
            cb_Nationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Nationality.FlatStyle = FlatStyle.Flat;
            cb_Nationality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Nationality.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cb_Nationality.Location = new Point(29, 33);
            cb_Nationality.Name = "cb_Nationality";
            cb_Nationality.Size = new Size(236, 29);
            cb_Nationality.TabIndex = 33;
            // 
            // pn_Avatar
            // 
            pn_Avatar.Anchor = AnchorStyles.Top;
            pn_Avatar.Controls.Add(label1);
            pn_Avatar.Controls.Add(Lb_id);
            pn_Avatar.Controls.Add(Pb_btn_AddAvatar);
            pn_Avatar.Controls.Add(Pb_imgPerfil);
            pn_Avatar.Location = new Point(407, 83);
            pn_Avatar.Name = "pn_Avatar";
            pn_Avatar.Size = new Size(185, 196);
            pn_Avatar.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(237, 230, 219);
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(26, 60, 64);
            label1.Location = new Point(32, 160);
            label1.Name = "label1";
            label1.Size = new Size(30, 21);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // Lb_id
            // 
            Lb_id.AutoSize = true;
            Lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lb_id.Location = new Point(59, 160);
            Lb_id.Name = "Lb_id";
            Lb_id.Size = new Size(0, 21);
            Lb_id.TabIndex = 6;
            // 
            // AddOrEditEmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(1083, 552);
            Controls.Add(BtnBack_EmployeeView);
            Controls.Add(Pb_btnConfirmar);
            Controls.Add(Lb_Title);
            Controls.Add(pn_form);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddOrEditEmployeeView";
            SizeChanged += AddOrEditEmployeeView_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnBack_EmployeeView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_AddAvatar).EndInit();
            pn_form.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_Avatar.ResumeLayout(false);
            pn_Avatar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lb_Title;
        private PictureBox Pb_btnConfirmar;
        private PictureBox BtnBack_EmployeeView;
        private PictureBox Pb_imgPerfil;
        private PictureBox Pb_btn_AddAvatar;
        private Label Lbl_Name;
        private TextBox Txt_Name;
        private TextBox Txt_LastName;
        private Label Lbl_LastName;
        private Label Lbl_Email;
        private TextBox Txt_Address;
        private Label Lbl_Address;
        private Label Lbl_Nationaliy;
        private TextBox Txt_idcard;
        private Label Lbl_Idcard;
        private TextBox Txt_Phone;
        private Label Lbl_Phone;
        private Label Lbl_Dateofhire;
        private Label Lbl_Birthdate;
        private DateTimePicker Dtp_Dateofhire;
        private DateTimePicker Dtp_Birthdate;
        private TextBox Txt_Salary;
        private Label Lbl_Salary;
        private ComboBox cb_Department;
        private Label Lbl_Department;
        private ComboBox Cb_Gender;
        private Label Lb_Genero;
        private Panel pn_form;
        private Panel pn_Avatar;
        private ComboBox cb_Nationality;
        private TextBox Txt_Email;
        private Label label1;
        private Label Lb_id;
        private Panel panel2;
        private Panel panel1;
    }
}