namespace CalculadoraSimple
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
            txtOperacion = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnDivision = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            btnMultiplicar = new Button();
            button15 = new Button();
            btnAtras = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtOperacion
            // 
            txtOperacion.Enabled = false;
            txtOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOperacion.Location = new Point(54, 31);
            txtOperacion.Name = "txtOperacion";
            txtOperacion.Size = new Size(465, 34);
            txtOperacion.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 12F);
            btn7.Location = new Point(75, 113);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 67);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 12F);
            btn8.Location = new Point(180, 113);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 67);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 12F);
            btn4.Location = new Point(75, 205);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 67);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 12F);
            btn9.Location = new Point(288, 113);
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 67);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 12F);
            btn1.Location = new Point(75, 300);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 67);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 12F);
            btn5.Location = new Point(180, 205);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 67);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 12F);
            btn6.Location = new Point(288, 205);
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 67);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 12F);
            btn3.Location = new Point(288, 300);
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 67);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Microsoft Sans Serif", 12F);
            btnDivision.Location = new Point(403, 389);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(82, 67);
            btnDivision.TabIndex = 9;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 12F);
            btn0.Location = new Point(75, 389);
            btn0.Name = "btn0";
            btn0.Size = new Size(82, 67);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 12F);
            btn2.Location = new Point(180, 300);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 67);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Microsoft Sans Serif", 12F);
            btnMas.Location = new Point(403, 113);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(82, 67);
            btnMas.TabIndex = 12;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Microsoft Sans Serif", 12F);
            btnMenos.Location = new Point(403, 205);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(82, 67);
            btnMenos.TabIndex = 13;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Microsoft Sans Serif", 12F);
            btnMultiplicar.Location = new Point(403, 300);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(82, 67);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Microsoft Sans Serif", 12F);
            button15.Location = new Point(180, 389);
            button15.Name = "button15";
            button15.Size = new Size(82, 67);
            button15.TabIndex = 15;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Microsoft Sans Serif", 12F);
            btnAtras.Location = new Point(288, 389);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(82, 67);
            btnAtras.TabIndex = 16;
            btnAtras.Text = "<-";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(375, 73);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(144, 34);
            txtResultado.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(574, 495);
            Controls.Add(txtResultado);
            Controls.Add(btnAtras);
            Controls.Add(button15);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btnDivision);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtOperacion);
            Name = "Form1";
            Text = "Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperacion;
        private Button btn7;
        private Button btn8;
        private Button btn4;
        private Button btn9;
        private Button btn1;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btnDivision;
        private Button btn0;
        private Button btn2;
        private Button btnMas;
        private Button btnMenos;
        private Button btnMultiplicar;
        private Button button15;
        private Button btnAtras;
        private TextBox txtResultado;
    }
}
