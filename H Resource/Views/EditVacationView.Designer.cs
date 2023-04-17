namespace H_Resource.Views
{
    partial class EditVacationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVacationView));
            Lbl_Edit = new Label();
            Pb_btnConfirmar = new PictureBox();
            Pb_btnAtras = new PictureBox();
            Lbl_State = new Label();
            Cmbox_State = new ComboBox();
            Lbl_Applicationdate = new Label();
            Dtp_Applicationdate = new DateTimePicker();
            Lbl_Startdate = new Label();
            Lbl_Enddate = new Label();
            Dtp_Startdate = new DateTimePicker();
            Dtp_Enddate = new DateTimePicker();
            Pb_imgPerfil = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Edit
            // 
            Lbl_Edit.AutoSize = true;
            Lbl_Edit.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Edit.ForeColor = Color.FromArgb(237, 230, 219);
            Lbl_Edit.Location = new Point(479, 26);
            Lbl_Edit.Name = "Lbl_Edit";
            Lbl_Edit.Size = new Size(102, 23);
            Lbl_Edit.TabIndex = 3;
            Lbl_Edit.Text = "Editar Datos";
            // 
            // Pb_btnConfirmar
            // 
            Pb_btnConfirmar.Cursor = Cursors.Hand;
            Pb_btnConfirmar.Image = Properties.Resources.Img_Btn_Comfirm;
            Pb_btnConfirmar.Location = new Point(938, 31);
            Pb_btnConfirmar.Name = "Pb_btnConfirmar";
            Pb_btnConfirmar.Size = new Size(110, 18);
            Pb_btnConfirmar.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btnConfirmar.TabIndex = 6;
            Pb_btnConfirmar.TabStop = false;
            // 
            // Pb_btnAtras
            // 
            Pb_btnAtras.Cursor = Cursors.Hand;
            Pb_btnAtras.Image = Properties.Resources.Img_Btn_Back;
            Pb_btnAtras.Location = new Point(35, 31);
            Pb_btnAtras.Name = "Pb_btnAtras";
            Pb_btnAtras.Size = new Size(72, 18);
            Pb_btnAtras.SizeMode = PictureBoxSizeMode.AutoSize;
            Pb_btnAtras.TabIndex = 7;
            Pb_btnAtras.TabStop = false;
            // 
            // Lbl_State
            // 
            Lbl_State.AutoSize = true;
            Lbl_State.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_State.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_State.Location = new Point(23, 56);
            Lbl_State.Name = "Lbl_State";
            Lbl_State.Size = new Size(51, 20);
            Lbl_State.TabIndex = 10;
            Lbl_State.Text = "Estado";
            // 
            // Cmbox_State
            // 
            Cmbox_State.BackColor = Color.FromArgb(237, 230, 219);
            Cmbox_State.FlatStyle = FlatStyle.System;
            Cmbox_State.Items.AddRange(new object[] { "Aprobado", "Revisión", "Denegado" });
            Cmbox_State.Location = new Point(37, 79);
            Cmbox_State.Name = "Cmbox_State";
            Cmbox_State.Size = new Size(236, 23);
            Cmbox_State.TabIndex = 37;
            Cmbox_State.Text = "Estado";
            Cmbox_State.KeyPress += Cmbox_State_KeyPress;
            // 
            // Lbl_Applicationdate
            // 
            Lbl_Applicationdate.AutoSize = true;
            Lbl_Applicationdate.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Applicationdate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Applicationdate.Location = new Point(23, 142);
            Lbl_Applicationdate.Name = "Lbl_Applicationdate";
            Lbl_Applicationdate.Size = new Size(119, 20);
            Lbl_Applicationdate.TabIndex = 38;
            Lbl_Applicationdate.Text = "Fecha de solicitud";
            // 
            // Dtp_Applicationdate
            // 
            Dtp_Applicationdate.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Applicationdate.Format = DateTimePickerFormat.Short;
            Dtp_Applicationdate.Location = new Point(37, 165);
            Dtp_Applicationdate.Name = "Dtp_Applicationdate";
            Dtp_Applicationdate.Size = new Size(154, 23);
            Dtp_Applicationdate.TabIndex = 39;
            // 
            // Lbl_Startdate
            // 
            Lbl_Startdate.AutoSize = true;
            Lbl_Startdate.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Startdate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Startdate.Location = new Point(23, 233);
            Lbl_Startdate.Name = "Lbl_Startdate";
            Lbl_Startdate.Size = new Size(101, 20);
            Lbl_Startdate.TabIndex = 40;
            Lbl_Startdate.Text = "Fecha de inicio";
            // 
            // Lbl_Enddate
            // 
            Lbl_Enddate.AutoSize = true;
            Lbl_Enddate.BackColor = Color.FromArgb(237, 230, 219);
            Lbl_Enddate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Enddate.Location = new Point(23, 332);
            Lbl_Enddate.Name = "Lbl_Enddate";
            Lbl_Enddate.Size = new Size(63, 20);
            Lbl_Enddate.TabIndex = 41;
            Lbl_Enddate.Text = "Fecha fin";
            // 
            // Dtp_Startdate
            // 
            Dtp_Startdate.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Startdate.Format = DateTimePickerFormat.Short;
            Dtp_Startdate.Location = new Point(41, 256);
            Dtp_Startdate.Name = "Dtp_Startdate";
            Dtp_Startdate.Size = new Size(154, 23);
            Dtp_Startdate.TabIndex = 42;
            // 
            // Dtp_Enddate
            // 
            Dtp_Enddate.CalendarMonthBackground = Color.FromArgb(29, 92, 99);
            Dtp_Enddate.Format = DateTimePickerFormat.Short;
            Dtp_Enddate.Location = new Point(41, 355);
            Dtp_Enddate.Name = "Dtp_Enddate";
            Dtp_Enddate.Size = new Size(154, 23);
            Dtp_Enddate.TabIndex = 43;
            // 
            // Pb_imgPerfil
            // 
            Pb_imgPerfil.BackColor = Color.FromArgb(237, 230, 219);
            Pb_imgPerfil.Enabled = false;
            Pb_imgPerfil.Image = Properties.Resources.Img_Avatar;
            Pb_imgPerfil.Location = new Point(69, 40);
            Pb_imgPerfil.Name = "Pb_imgPerfil";
            Pb_imgPerfil.Size = new Size(207, 183);
            Pb_imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_imgPerfil.TabIndex = 44;
            Pb_imgPerfil.TabStop = false;
            Pb_imgPerfil.Paint += Pb_imgPerfil_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 230, 219);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(35, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 421);
            panel1.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.Controls.Add(Cmbox_State);
            panel2.Controls.Add(Lbl_State);
            panel2.Controls.Add(Lbl_Applicationdate);
            panel2.Controls.Add(Dtp_Applicationdate);
            panel2.Controls.Add(Dtp_Enddate);
            panel2.Controls.Add(Lbl_Startdate);
            panel2.Controls.Add(Lbl_Enddate);
            panel2.Controls.Add(Dtp_Startdate);
            panel2.Location = new Point(17, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 394);
            panel2.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.Controls.Add(Pb_imgPerfil);
            panel3.Location = new Point(508, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 275);
            panel3.TabIndex = 46;
            // 
            // EditVacationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 60, 64);
            ClientSize = new Size(1083, 552);
            Controls.Add(panel1);
            Controls.Add(Pb_btnAtras);
            Controls.Add(Pb_btnConfirmar);
            Controls.Add(Lbl_Edit);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditVacationView";
            Paint += EditVacationForm_Paint;
            ((System.ComponentModel.ISupportInitialize)Pb_btnConfirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_imgPerfil).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Edit;
        private PictureBox Pb_btnConfirmar;
        private PictureBox Pb_btnAtras;
        private Label Lbl_State;
        private ComboBox Cmbox_State;
        private Label Lbl_Applicationdate;
        private DateTimePicker Dtp_Applicationdate;
        private Label Lbl_Startdate;
        private Label Lbl_Enddate;
        private DateTimePicker Dtp_Startdate;
        private DateTimePicker Dtp_Enddate;
        private PictureBox Pb_imgPerfil;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}