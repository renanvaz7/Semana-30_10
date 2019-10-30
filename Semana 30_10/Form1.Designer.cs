namespace Semana_30_10
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_calcular = new System.Windows.Forms.Button();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_valor1 = new System.Windows.Forms.Label();
            this.label_valor2 = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(371, 352);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 0;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(355, 121);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor1.TabIndex = 1;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(355, 166);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor2.TabIndex = 2;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(356, 207);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 20);
            this.textBox_result.TabIndex = 3;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(335, 24);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(168, 63);
            this.label_titulo.TabIndex = 4;
            this.label_titulo.Text = "Soma";
            // 
            // label_valor1
            // 
            this.label_valor1.AutoSize = true;
            this.label_valor1.Location = new System.Drawing.Point(156, 128);
            this.label_valor1.Name = "label_valor1";
            this.label_valor1.Size = new System.Drawing.Size(40, 13);
            this.label_valor1.TabIndex = 5;
            this.label_valor1.Text = "Valor 1";
            // 
            // label_valor2
            // 
            this.label_valor2.AutoSize = true;
            this.label_valor2.Location = new System.Drawing.Point(156, 173);
            this.label_valor2.Name = "label_valor2";
            this.label_valor2.Size = new System.Drawing.Size(40, 13);
            this.label_valor2.TabIndex = 6;
            this.label_valor2.Text = "Valor 2";
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(156, 214);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(55, 13);
            this.label_resultado.TabIndex = 7;
            this.label_resultado.Text = "Resultado";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(677, 352);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 8;
            this.button_next.Text = "Next page";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label_valor2);
            this.Controls.Add(this.label_valor1);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.button_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_valor1;
        private System.Windows.Forms.Label label_valor2;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_next;
    }
}

