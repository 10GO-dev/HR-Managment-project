namespace H_Resource.Views
{
    partial class Btn_Delete_EmployeesControl
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
            Lbl_employeescontroler = new Label();
            Pb_btn_SiControler = new PictureBox();
            Pb_btn_NoControler = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_SiControler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NoControler).BeginInit();
            SuspendLayout();
            // 
            // Lbl_employeescontroler
            // 
            Lbl_employeescontroler.AutoSize = true;
            Lbl_employeescontroler.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_employeescontroler.ForeColor = Color.FromArgb(237, 230, 219);
            Lbl_employeescontroler.Location = new Point(5, 33);
            Lbl_employeescontroler.Name = "Lbl_employeescontroler";
            Lbl_employeescontroler.Size = new Size(367, 22);
            Lbl_employeescontroler.TabIndex = 0;
            Lbl_employeescontroler.Text = "Estas seguro de borrar este Empleado";
            // 
            // Pb_btn_SiControler
            // 
            Pb_btn_SiControler.Image = Properties.Resources.img_Btn_Si_EmployeesControler;
            Pb_btn_SiControler.Location = new Point(32, 103);
            Pb_btn_SiControler.Name = "Pb_btn_SiControler";
            Pb_btn_SiControler.Size = new Size(82, 32);
            Pb_btn_SiControler.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_SiControler.TabIndex = 1;
            Pb_btn_SiControler.TabStop = false;
            Pb_btn_SiControler.MouseEnter += Pb_btn_SiControler_MouseEnter;
            Pb_btn_SiControler.MouseLeave += Pb_btn_SiControler_MouseLeave;
            // 
            // Pb_btn_NoControler
            // 
            Pb_btn_NoControler.Image = Properties.Resources.img_Btn_No_EmployeesControler;
            Pb_btn_NoControler.Location = new Point(260, 103);
            Pb_btn_NoControler.Name = "Pb_btn_NoControler";
            Pb_btn_NoControler.Size = new Size(82, 32);
            Pb_btn_NoControler.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btn_NoControler.TabIndex = 2;
            Pb_btn_NoControler.TabStop = false;
            Pb_btn_NoControler.Click += Pb_btn_NoControler_Click;
            Pb_btn_NoControler.MouseEnter += Pb_btn_NoControler_MouseEnter;
            Pb_btn_NoControler.MouseLeave += Pb_btn_NoControler_MouseLeave;
            // 
            // Btn_Delete_EmployeesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 92, 99);
            Controls.Add(Pb_btn_NoControler);
            Controls.Add(Pb_btn_SiControler);
            Controls.Add(Lbl_employeescontroler);
            Name = "Btn_Delete_EmployeesControl";
            Size = new Size(375, 166);
            Paint += Btn_Delete_EmployeesControl_Paint;
            ((System.ComponentModel.ISupportInitialize)Pb_btn_SiControler).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btn_NoControler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_employeescontroler;
        private PictureBox Pb_btn_SiControler;
        private PictureBox Pb_btn_NoControler;
    }
}
