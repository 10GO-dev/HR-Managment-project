namespace H_Resource.Views
{
    partial class PayrollView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollView));
            Pn_bgTablaPayroll = new Panel();
            Tbl_layaut_Box = new TableLayoutPanel();
            Pb_txtPayroll = new PictureBox();
            Pb_btnClosePayroll = new PictureBox();
            Pb_SearchBar = new PictureBox();
            Txtbox_SearchBar = new TextBox();
            Pb_Shape = new PictureBox();
            Pn_bgTablaPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb_txtPayroll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnClosePayroll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).BeginInit();
            SuspendLayout();
            // 
            // Pn_bgTablaPayroll
            // 
            Pn_bgTablaPayroll.BackColor = Color.FromArgb(237, 230, 219);
            Pn_bgTablaPayroll.BackgroundImageLayout = ImageLayout.None;
            Pn_bgTablaPayroll.Controls.Add(Tbl_layaut_Box);
            Pn_bgTablaPayroll.Location = new Point(37, 49);
            Pn_bgTablaPayroll.Name = "Pn_bgTablaPayroll";
            Pn_bgTablaPayroll.Size = new Size(950, 374);
            Pn_bgTablaPayroll.TabIndex = 2;
            // 
            // Tbl_layaut_Box
            // 
            Tbl_layaut_Box.ColumnCount = 1;
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Tbl_layaut_Box.Location = new Point(0, 0);
            Tbl_layaut_Box.Name = "Tbl_layaut_Box";
            Tbl_layaut_Box.RowCount = 2;
            Tbl_layaut_Box.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_layaut_Box.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_layaut_Box.Size = new Size(950, 377);
            Tbl_layaut_Box.TabIndex = 0;
            // 
            // Pb_txtPayroll
            // 
            Pb_txtPayroll.Image = Properties.Resources.Img_Txt_Nomina;
            Pb_txtPayroll.Location = new Point(68, 12);
            Pb_txtPayroll.Name = "Pb_txtPayroll";
            Pb_txtPayroll.Size = new Size(150, 36);
            Pb_txtPayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_txtPayroll.TabIndex = 3;
            Pb_txtPayroll.TabStop = false;
            // 
            // Pb_btnClosePayroll
            // 
            Pb_btnClosePayroll.Cursor = Cursors.Hand;
            Pb_btnClosePayroll.Image = Properties.Resources.img_close_button;
            Pb_btnClosePayroll.Location = new Point(991, 12);
            Pb_btnClosePayroll.Name = "Pb_btnClosePayroll";
            Pb_btnClosePayroll.Size = new Size(32, 25);
            Pb_btnClosePayroll.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_btnClosePayroll.TabIndex = 4;
            Pb_btnClosePayroll.TabStop = false;
            Pb_btnClosePayroll.MouseEnter += Pb_btnClosePayroll_MouseEnter;
            Pb_btnClosePayroll.MouseLeave += Pb_btnClosePayroll_MouseLeave;
            // 
            // Pb_SearchBar
            // 
            Pb_SearchBar.Image = (Image)resources.GetObject("Pb_SearchBar.Image");
            Pb_SearchBar.Location = new Point(446, 13);
            Pb_SearchBar.Name = "Pb_SearchBar";
            Pb_SearchBar.Size = new Size(505, 30);
            Pb_SearchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_SearchBar.TabIndex = 11;
            Pb_SearchBar.TabStop = false;
            // 
            // Txtbox_SearchBar
            // 
            Txtbox_SearchBar.BackColor = Color.FromArgb(237, 230, 219);
            Txtbox_SearchBar.BorderStyle = BorderStyle.None;
            Txtbox_SearchBar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Txtbox_SearchBar.ForeColor = Color.FromArgb(26, 60, 64);
            Txtbox_SearchBar.Location = new Point(484, 22);
            Txtbox_SearchBar.Name = "Txtbox_SearchBar";
            Txtbox_SearchBar.Size = new Size(455, 15);
            Txtbox_SearchBar.TabIndex = 13;
            Txtbox_SearchBar.Tag = "";
            Txtbox_SearchBar.Text = "Buscar";
            Txtbox_SearchBar.Enter += Txtbox_SearchBar_Enter;
            Txtbox_SearchBar.Leave += Txtbox_SearchBar_Leave;
            // 
            // Pb_Shape
            // 
            Pb_Shape.BackColor = Color.FromArgb(237, 230, 219);
            Pb_Shape.Cursor = Cursors.Hand;
            Pb_Shape.Image = (Image)resources.GetObject("Pb_Shape.Image");
            Pb_Shape.Location = new Point(454, 16);
            Pb_Shape.Name = "Pb_Shape";
            Pb_Shape.Size = new Size(24, 24);
            Pb_Shape.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb_Shape.TabIndex = 14;
            Pb_Shape.TabStop = false;
            // 
            // PayrollForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 125, 122);
            ClientSize = new Size(1035, 450);
            Controls.Add(Pb_Shape);
            Controls.Add(Txtbox_SearchBar);
            Controls.Add(Pb_SearchBar);
            Controls.Add(Pb_btnClosePayroll);
            Controls.Add(Pb_txtPayroll);
            Controls.Add(Pn_bgTablaPayroll);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PayrollForm";
            Paint += PayrollForm_Paint;
            Pn_bgTablaPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pb_txtPayroll).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_btnClosePayroll).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_SearchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_Shape).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pn_bgTablaPayroll;
        private TableLayoutPanel Tbl_layaut_Box;
        private PictureBox Pb_txtPayroll;
        private PictureBox Pb_btnClosePayroll;
        private PictureBox Pb_SearchBar;
        private TextBox Txtbox_SearchBar;
        private PictureBox Pb_Shape;
    }
}