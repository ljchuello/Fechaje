namespace Fechaje
{
    partial class Form1
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
            monthCalendar1 = new MonthCalendar();
            txtFechaActual = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNroMesesMuestra = new TextBox();
            label3 = new Label();
            txtNroMesesPrueba = new TextBox();
            txtPruebaInicio = new Label();
            txtMuestraInicio = new TextBox();
            txtMuestraFin = new TextBox();
            label5 = new Label();
            txtPruebaFin = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPruebaInicios = new TextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(278, 36);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(111, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 71);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Nro. Meses muestra";
            // 
            // txtNroMesesMuestra
            // 
            txtNroMesesMuestra.Location = new Point(278, 89);
            txtNroMesesMuestra.Name = "txtNroMesesMuestra";
            txtNroMesesMuestra.Size = new Size(111, 23);
            txtNroMesesMuestra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 127);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 6;
            label3.Text = "Nro. Meses pruebas";
            // 
            // txtNroMesesPrueba
            // 
            txtNroMesesPrueba.Location = new Point(278, 145);
            txtNroMesesPrueba.Name = "txtNroMesesPrueba";
            txtNroMesesPrueba.Size = new Size(111, 23);
            txtNroMesesPrueba.TabIndex = 5;
            // 
            // txtPruebaInicio
            // 
            txtPruebaInicio.AutoSize = true;
            txtPruebaInicio.Location = new Point(58, 189);
            txtPruebaInicio.Name = "txtPruebaInicio";
            txtPruebaInicio.Size = new Size(87, 15);
            txtPruebaInicio.TabIndex = 7;
            txtPruebaInicio.Text = "Inicio muestras";
            // 
            // txtMuestraInicio
            // 
            txtMuestraInicio.Location = new Point(58, 207);
            txtMuestraInicio.Name = "txtMuestraInicio";
            txtMuestraInicio.Size = new Size(111, 23);
            txtMuestraInicio.TabIndex = 8;
            // 
            // txtMuestraFin
            // 
            txtMuestraFin.Location = new Point(58, 257);
            txtMuestraFin.Name = "txtMuestraFin";
            txtMuestraFin.Size = new Size(111, 23);
            txtMuestraFin.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 239);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Fin muestras";
            // 
            // txtPruebaFin
            // 
            txtPruebaFin.Location = new Point(217, 257);
            txtPruebaFin.Name = "txtPruebaFin";
            txtPruebaFin.Size = new Size(111, 23);
            txtPruebaFin.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 239);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 13;
            label6.Text = "Fin pruebas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 189);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 11;
            label7.Text = "Inicio pruebas";
            // 
            // txtPruebaInicios
            // 
            txtPruebaInicios.Location = new Point(217, 207);
            txtPruebaInicios.Name = "txtPruebaInicios";
            txtPruebaInicios.Size = new Size(111, 23);
            txtPruebaInicios.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 294);
            Controls.Add(txtPruebaInicios);
            Controls.Add(txtPruebaFin);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtMuestraFin);
            Controls.Add(label5);
            Controls.Add(txtMuestraInicio);
            Controls.Add(txtPruebaInicio);
            Controls.Add(label3);
            Controls.Add(txtNroMesesPrueba);
            Controls.Add(label2);
            Controls.Add(txtNroMesesMuestra);
            Controls.Add(label1);
            Controls.Add(txtFechaActual);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox txtFechaActual;
        private Label label1;
        private Label label2;
        private TextBox txtNroMesesMuestra;
        private Label label3;
        private TextBox txtNroMesesPrueba;
        private Label txtPruebaInicio;
        private TextBox txtMuestraInicio;
        private TextBox txtMuestraFin;
        private Label label5;
        private TextBox txtPruebaFin;
        private Label label6;
        private Label label7;
        private TextBox txtPruebaInicios;
    }
}
