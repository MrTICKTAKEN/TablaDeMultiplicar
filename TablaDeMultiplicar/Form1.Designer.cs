namespace TablaDeMultiplicar
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1Mul = new System.Windows.Forms.Label();
            this.label2Numero = new System.Windows.Forms.Label();
            this.btnMos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1Mul
            // 
            this.label1Mul.AutoSize = true;
            this.label1Mul.Location = new System.Drawing.Point(152, 68);
            this.label1Mul.Name = "label1Mul";
            this.label1Mul.Size = new System.Drawing.Size(118, 13);
            this.label1Mul.TabIndex = 0;
            this.label1Mul.Text = "Ingresar para multiplicar";
            // 
            // label2Numero
            // 
            this.label2Numero.AutoSize = true;
            this.label2Numero.Location = new System.Drawing.Point(176, 138);
            this.label2Numero.Name = "label2Numero";
            this.label2Numero.Size = new System.Drawing.Size(0, 13);
            this.label2Numero.TabIndex = 1;
            // 
            // btnMos
            // 
            this.btnMos.Location = new System.Drawing.Point(167, 112);
            this.btnMos.Name = "btnMos";
            this.btnMos.Size = new System.Drawing.Size(75, 23);
            this.btnMos.TabIndex = 2;
            this.btnMos.Text = "Multiplicar";
            this.btnMos.UseVisualStyleBackColor = true;
            this.btnMos.Click += new System.EventHandler(this.btnMos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMos);
            this.Controls.Add(this.label2Numero);
            this.Controls.Add(this.label1Mul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Mul;
        private System.Windows.Forms.Label label2Numero;
        private System.Windows.Forms.Button btnMos;
        private System.Windows.Forms.TextBox textBox1;
    }
}

