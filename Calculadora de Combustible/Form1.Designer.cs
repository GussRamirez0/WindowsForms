namespace Calculadora_de_Combustible
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
            txtDistanciaRecorrida = new TextBox();
            txtRendimiento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            txtresult = new TextBox();
            SuspendLayout();
            // 
            // txtDistanciaRecorrida
            // 
            txtDistanciaRecorrida.Location = new Point(18, 60);
            txtDistanciaRecorrida.Name = "txtDistanciaRecorrida";
            txtDistanciaRecorrida.Size = new Size(100, 23);
            txtDistanciaRecorrida.TabIndex = 0;
            // 
            // txtRendimiento
            // 
            txtRendimiento.Location = new Point(18, 120);
            txtRendimiento.Name = "txtRendimiento";
            txtRendimiento.Size = new Size(100, 23);
            txtRendimiento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese los valores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 42);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 3;
            label2.Text = "Distancia Recorrida (KM)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 102);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 4;
            label3.Text = "Rendimiento (kilómetros por galón)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 160);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 224);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(132, 58);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtresult
            // 
            txtresult.Enabled = false;
            txtresult.Location = new Point(12, 195);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(100, 23);
            txtresult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtresult);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRendimiento);
            Controls.Add(txtDistanciaRecorrida);
            Name = "Form1";
            Text = "Calculadora de Combustible";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDistanciaRecorrida;
        private TextBox txtRendimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
        private TextBox txtresult;
    }
}
