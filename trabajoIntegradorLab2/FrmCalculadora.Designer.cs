namespace trabajoIntegradorLab2
{
    partial class FrmCalculadora
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
            label1 = new Label();
            selecOperacion = new ComboBox();
            primerOperador = new TextBox();
            SegundoOperador = new TextBox();
            Operar = new Button();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            selecReprecentacion = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(220, 59);
            label1.TabIndex = 0;
            label1.Text = "Resultado:";
            label1.Click += label1_Click;
            // 
            // selecOperacion
            // 
            selecOperacion.AllowDrop = true;
            selecOperacion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selecOperacion.FormattingEnabled = true;
            selecOperacion.Items.AddRange(new object[] { "\"\"", "+", "-", "*", "/" });
            selecOperacion.Location = new Point(300, 300);
            selecOperacion.Name = "selecOperacion";
            selecOperacion.Size = new Size(121, 40);
            selecOperacion.TabIndex = 1;
            // 
            // primerOperador
            // 
            primerOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            primerOperador.Location = new Point(40, 300);
            primerOperador.Name = "primerOperador";
            primerOperador.Size = new Size(100, 39);
            primerOperador.TabIndex = 2;
            // 
            // SegundoOperador
            // 
            SegundoOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SegundoOperador.Location = new Point(660, 300);
            SegundoOperador.Name = "SegundoOperador";
            SegundoOperador.Size = new Size(100, 39);
            SegundoOperador.TabIndex = 3;
            // 
            // Operar
            // 
            Operar.AutoSize = true;
            Operar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Operar.Location = new Point(40, 500);
            Operar.Name = "Operar";
            Operar.Size = new Size(97, 42);
            Operar.TabIndex = 5;
            Operar.Text = "Operar";
            Operar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(300, 500);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 6;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(651, 500);
            button2.Name = "button2";
            button2.Size = new Size(109, 42);
            button2.TabIndex = 7;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 240);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 8;
            label2.Text = "Primer Operador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 240);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 9;
            label3.Text = "Operacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(540, 240);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 10;
            label4.Text = "Segundo Operador";
            label4.Click += label4_Click;
            // 
            // selecReprecentacion
            // 
            selecReprecentacion.FormattingEnabled = true;
            selecReprecentacion.Items.AddRange(new object[] { "Decimal", "Binario" });
            selecReprecentacion.Location = new Point(300, 140);
            selecReprecentacion.MultiColumn = true;
            selecReprecentacion.Name = "selecReprecentacion";
            selecReprecentacion.Size = new Size(120, 94);
            selecReprecentacion.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(selecReprecentacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Operar);
            Controls.Add(SegundoOperador);
            Controls.Add(primerOperador);
            Controls.Add(selecOperacion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Mateo Elisaleco";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox selecOperacion;
        private TextBox primerOperador;
        private TextBox SegundoOperador;
        private CheckedListBox checkedListBox1;
        private Button Operar;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox selecReprecentacion;
    }
}