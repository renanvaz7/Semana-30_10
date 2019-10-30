namespace Lista
{
    partial class Form2
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_valor1 = new System.Windows.Forms.Label();
            this.label_valor2 = new System.Windows.Forms.Label();
            this.label_valor3 = new System.Windows.Forms.Label();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.textBox_valor3 = new System.Windows.Forms.TextBox();
            this.button_result = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(231, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(454, 63);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Qual maior valor?";
            this.label_titulo.Click += new System.EventHandler(this.Label_titulo_Click);
            // 
            // label_valor1
            // 
            this.label_valor1.AutoSize = true;
            this.label_valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor1.Location = new System.Drawing.Point(12, 102);
            this.label_valor1.Name = "label_valor1";
            this.label_valor1.Size = new System.Drawing.Size(216, 39);
            this.label_valor1.TabIndex = 2;
            this.label_valor1.Text = "Digite 1 valor";
            // 
            // label_valor2
            // 
            this.label_valor2.AutoSize = true;
            this.label_valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor2.Location = new System.Drawing.Point(12, 166);
            this.label_valor2.Name = "label_valor2";
            this.label_valor2.Size = new System.Drawing.Size(325, 39);
            this.label_valor2.TabIndex = 3;
            this.label_valor2.Text = "Digite mais um valor";
            this.label_valor2.Click += new System.EventHandler(this.Label_custofab_Click);
            // 
            // label_valor3
            // 
            this.label_valor3.AutoSize = true;
            this.label_valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor3.Location = new System.Drawing.Point(12, 228);
            this.label_valor3.Name = "label_valor3";
            this.label_valor3.Size = new System.Drawing.Size(274, 39);
            this.label_valor3.TabIndex = 4;
            this.label_valor3.Text = "Digite outro valor";
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_valor1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_valor1.Location = new System.Drawing.Point(374, 96);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(158, 45);
            this.textBox_valor1.TabIndex = 12;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_valor2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_valor2.Location = new System.Drawing.Point(374, 160);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(158, 45);
            this.textBox_valor2.TabIndex = 13;
            // 
            // textBox_valor3
            // 
            this.textBox_valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_valor3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_valor3.Location = new System.Drawing.Point(374, 222);
            this.textBox_valor3.Name = "textBox_valor3";
            this.textBox_valor3.Size = new System.Drawing.Size(158, 45);
            this.textBox_valor3.TabIndex = 14;
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_result.Location = new System.Drawing.Point(19, 339);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(150, 48);
            this.button_result.TabIndex = 15;
            this.button_result.Text = "Resultado";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_result.Location = new System.Drawing.Point(374, 339);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(158, 45);
            this.textBox_result.TabIndex = 16;
            // 
            // button_prox
            // 
            this.button_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prox.Location = new System.Drawing.Point(639, 336);
            this.button_prox.Name = "button_prox";
            this.button_prox.Size = new System.Drawing.Size(139, 48);
            this.button_prox.TabIndex = 17;
            this.button_prox.Text = "Proximo";
            this.button_prox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_prox);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.textBox_valor3);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.label_valor3);
            this.Controls.Add(this.label_valor2);
            this.Controls.Add(this.label_valor1);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_valor1;
        private System.Windows.Forms.Label label_valor2;
        private System.Windows.Forms.Label label_valor3;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.TextBox textBox_valor3;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_prox;
    }
}