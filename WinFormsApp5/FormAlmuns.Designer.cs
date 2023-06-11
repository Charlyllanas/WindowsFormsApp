namespace WinFormsApp5
{
    partial class FormAlmuns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmuns));
            btnBecaDeportiva = new Button();
            btnBecaExcelencia = new Button();
            btnBecaAyuda = new Button();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelBecaExcelencia = new Panel();
            label5 = new Label();
            label4 = new Label();
            txtPromedioExcelencia = new TextBox();
            txtCorreoExcelencia = new TextBox();
            label1 = new Label();
            panelBecaDeportiva = new Panel();
            label8 = new Label();
            cmbClubDeportiva = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtPromedioDeportiva = new TextBox();
            textCorreoDeportiva = new TextBox();
            label2 = new Label();
            panelBecaAyuda = new Panel();
            txtIngresoMensualAyuda = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtPromedioAyuda = new TextBox();
            textCorreoAyuda = new TextBox();
            label3 = new Label();
            panelBtnRegistrar = new Panel();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelBecaExcelencia.SuspendLayout();
            panelBecaDeportiva.SuspendLayout();
            panelBecaAyuda.SuspendLayout();
            panelBtnRegistrar.SuspendLayout();
            SuspendLayout();
            // 
            // btnBecaDeportiva
            // 
            btnBecaDeportiva.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBecaDeportiva.Location = new Point(63, 282);
            btnBecaDeportiva.Name = "btnBecaDeportiva";
            btnBecaDeportiva.Size = new Size(142, 86);
            btnBecaDeportiva.TabIndex = 0;
            btnBecaDeportiva.Text = "Beca Deportiva";
            btnBecaDeportiva.UseVisualStyleBackColor = true;
            btnBecaDeportiva.Click += btnBecaDeportiva_Click;
            btnBecaDeportiva.MouseEnter += btnBecaDeportiva_MouseEnter;
            // 
            // btnBecaExcelencia
            // 
            btnBecaExcelencia.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBecaExcelencia.FlatStyle = FlatStyle.System;
            btnBecaExcelencia.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBecaExcelencia.Image = (Image)resources.GetObject("btnBecaExcelencia.Image");
            btnBecaExcelencia.Location = new Point(63, 169);
            btnBecaExcelencia.Name = "btnBecaExcelencia";
            btnBecaExcelencia.Size = new Size(142, 86);
            btnBecaExcelencia.TabIndex = 1;
            btnBecaExcelencia.Text = "Beca de Excelencia";
            btnBecaExcelencia.UseVisualStyleBackColor = true;
            btnBecaExcelencia.MouseEnter += btnBecaExcelencia_MouseEnter;
            // 
            // btnBecaAyuda
            // 
            btnBecaAyuda.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBecaAyuda.Location = new Point(63, 396);
            btnBecaAyuda.Name = "btnBecaAyuda";
            btnBecaAyuda.Size = new Size(142, 86);
            btnBecaAyuda.TabIndex = 2;
            btnBecaAyuda.Text = "Beca de Ayuda";
            btnBecaAyuda.UseVisualStyleBackColor = true;
            btnBecaAyuda.MouseEnter += btnBecaAyuda_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(223, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(63, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panelBecaExcelencia);
            flowLayoutPanel1.Controls.Add(panelBecaDeportiva);
            flowLayoutPanel1.Controls.Add(panelBecaAyuda);
            flowLayoutPanel1.Controls.Add(panelBtnRegistrar);
            flowLayoutPanel1.Location = new Point(277, 166);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(621, 502);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panelBecaExcelencia
            // 
            panelBecaExcelencia.Controls.Add(label5);
            panelBecaExcelencia.Controls.Add(label4);
            panelBecaExcelencia.Controls.Add(txtPromedioExcelencia);
            panelBecaExcelencia.Controls.Add(txtCorreoExcelencia);
            panelBecaExcelencia.Controls.Add(label1);
            panelBecaExcelencia.Location = new Point(3, 3);
            panelBecaExcelencia.Name = "panelBecaExcelencia";
            panelBecaExcelencia.Size = new Size(614, 102);
            panelBecaExcelencia.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 107);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Promedio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 63);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo electronico:";
            // 
            // txtPromedioExcelencia
            // 
            txtPromedioExcelencia.Location = new Point(185, 100);
            txtPromedioExcelencia.Name = "txtPromedioExcelencia";
            txtPromedioExcelencia.Size = new Size(248, 27);
            txtPromedioExcelencia.TabIndex = 2;
            txtPromedioExcelencia.KeyPress += txtPromedio_KeyPress;
            // 
            // txtCorreoExcelencia
            // 
            txtCorreoExcelencia.Location = new Point(185, 56);
            txtCorreoExcelencia.Name = "txtCorreoExcelencia";
            txtCorreoExcelencia.Size = new Size(248, 27);
            txtCorreoExcelencia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Beca de Excelencia";
            // 
            // panelBecaDeportiva
            // 
            panelBecaDeportiva.Controls.Add(label8);
            panelBecaDeportiva.Controls.Add(cmbClubDeportiva);
            panelBecaDeportiva.Controls.Add(label6);
            panelBecaDeportiva.Controls.Add(label7);
            panelBecaDeportiva.Controls.Add(txtPromedioDeportiva);
            panelBecaDeportiva.Controls.Add(textCorreoDeportiva);
            panelBecaDeportiva.Controls.Add(label2);
            panelBecaDeportiva.Location = new Point(3, 111);
            panelBecaDeportiva.Name = "panelBecaDeportiva";
            panelBecaDeportiva.Size = new Size(617, 74);
            panelBecaDeportiva.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 137);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 10;
            label8.Text = "Club Deportivo";
            // 
            // cmbClubDeportiva
            // 
            cmbClubDeportiva.FormattingEnabled = true;
            cmbClubDeportiva.Items.AddRange(new object[] { "Futbol", "Basquetbol", "Voleivol" });
            cmbClubDeportiva.Location = new Point(185, 137);
            cmbClubDeportiva.Name = "cmbClubDeportiva";
            cmbClubDeportiva.Size = new Size(248, 28);
            cmbClubDeportiva.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 90);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 8;
            label6.Text = "Promedio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 46);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 7;
            label7.Text = "Correo electronico:";
            // 
            // txtPromedioDeportiva
            // 
            txtPromedioDeportiva.Location = new Point(185, 83);
            txtPromedioDeportiva.Name = "txtPromedioDeportiva";
            txtPromedioDeportiva.Size = new Size(248, 27);
            txtPromedioDeportiva.TabIndex = 6;
            txtPromedioDeportiva.KeyPress += txtPromedioDeportiva_KeyPress;
            // 
            // textCorreoDeportiva
            // 
            textCorreoDeportiva.Location = new Point(185, 39);
            textCorreoDeportiva.Name = "textCorreoDeportiva";
            textCorreoDeportiva.Size = new Size(248, 27);
            textCorreoDeportiva.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 13);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Beca Deportiva";
            // 
            // panelBecaAyuda
            // 
            panelBecaAyuda.Controls.Add(txtIngresoMensualAyuda);
            panelBecaAyuda.Controls.Add(label9);
            panelBecaAyuda.Controls.Add(label10);
            panelBecaAyuda.Controls.Add(label11);
            panelBecaAyuda.Controls.Add(txtPromedioAyuda);
            panelBecaAyuda.Controls.Add(textCorreoAyuda);
            panelBecaAyuda.Controls.Add(label3);
            panelBecaAyuda.Location = new Point(3, 191);
            panelBecaAyuda.Name = "panelBecaAyuda";
            panelBecaAyuda.Size = new Size(614, 85);
            panelBecaAyuda.TabIndex = 1;
            // 
            // txtIngresoMensualAyuda
            // 
            txtIngresoMensualAyuda.Location = new Point(187, 141);
            txtIngresoMensualAyuda.Name = "txtIngresoMensualAyuda";
            txtIngresoMensualAyuda.Size = new Size(248, 27);
            txtIngresoMensualAyuda.TabIndex = 17;
            txtIngresoMensualAyuda.KeyPress += txtIngresoMensualAyuda_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 148);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 16;
            label9.Text = "Ingreso mensual:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 101);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 14;
            label10.Text = "Promedio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 57);
            label11.Name = "label11";
            label11.Size = new Size(135, 20);
            label11.TabIndex = 13;
            label11.Text = "Correo electronico:";
            // 
            // txtPromedioAyuda
            // 
            txtPromedioAyuda.Location = new Point(187, 94);
            txtPromedioAyuda.Name = "txtPromedioAyuda";
            txtPromedioAyuda.Size = new Size(248, 27);
            txtPromedioAyuda.TabIndex = 12;
            txtPromedioAyuda.KeyPress += txtPromedioAyuda_KeyPress;
            // 
            // textCorreoAyuda
            // 
            textCorreoAyuda.Location = new Point(187, 50);
            textCorreoAyuda.Name = "textCorreoAyuda";
            textCorreoAyuda.Size = new Size(248, 27);
            textCorreoAyuda.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 14);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 0;
            label3.Text = "Beca de Ayuda";
            // 
            // panelBtnRegistrar
            // 
            panelBtnRegistrar.Controls.Add(btnRegistrar);
            panelBtnRegistrar.Location = new Point(3, 282);
            panelBtnRegistrar.Name = "panelBtnRegistrar";
            panelBtnRegistrar.Size = new Size(614, 81);
            panelBtnRegistrar.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(209, 22);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(200, 41);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar.";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormAlmuns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 524);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Controls.Add(btnBecaAyuda);
            Controls.Add(btnBecaExcelencia);
            Controls.Add(btnBecaDeportiva);
            Name = "FormAlmuns";
            Text = "FormAlmuns";
            FormClosed += FormAlmuns_FormClosed;
            Load += FormAlmuns_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panelBecaExcelencia.ResumeLayout(false);
            panelBecaExcelencia.PerformLayout();
            panelBecaDeportiva.ResumeLayout(false);
            panelBecaDeportiva.PerformLayout();
            panelBecaAyuda.ResumeLayout(false);
            panelBecaAyuda.PerformLayout();
            panelBtnRegistrar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBecaDeportiva;
        private Button btnBecaExcelencia;
        private Button btnBecaAyuda;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelBecaExcelencia;
        private Label label1;
        private Panel panelBecaAyuda;
        private Label label2;
        private Panel panelBecaDeportiva;
        private TextBox txtPromedioExcelencia;
        private TextBox txtCorreoExcelencia;
        private Label label5;
        private Label label4;
        private Label label8;
        private ComboBox cmbClubDeportiva;
        private Label label6;
        private Label label7;
        private TextBox txtPromedioDeportiva;
        private TextBox textCorreoDeportiva;
        private TextBox txtIngresoMensualAyuda;
        private Label label9;
        private Label label10;
        private TextBox txtPromedioAyuda;
        private Button btnRegistrar;
        private Label label11;
        private TextBox textCorreoAyuda;
        private Label label3;
        private Panel panelBtnRegistrar;
    }
}