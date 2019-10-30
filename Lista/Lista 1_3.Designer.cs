namespace Lista
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_custofab = new System.Windows.Forms.Label();
            this.label_impostodist = new System.Windows.Forms.Label();
            this.label_impostos = new System.Windows.Forms.Label();
            this.label_imp28 = new System.Windows.Forms.Label();
            this.label_imp45 = new System.Windows.Forms.Label();
            this.label_custofi = new System.Windows.Forms.Label();
            this.textBox_custof = new System.Windows.Forms.TextBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_prox = new System.Windows.Forms.Button();
            this.textBox_custofab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(248, 18);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(379, 63);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Custo do carro";
            this.label_titulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_custofab
            // 
            this.label_custofab.AutoSize = true;
            this.label_custofab.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_custofab.Location = new System.Drawing.Point(23, 117);
            this.label_custofab.Name = "label_custofab";
            this.label_custofab.Size = new System.Drawing.Size(264, 39);
            this.label_custofab.TabIndex = 1;
            this.label_custofab.Text = "Custo de fábrica";
            this.label_custofab.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label_impostodist
            // 
            this.label_impostodist.AutoSize = true;
            this.label_impostodist.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_impostodist.Location = new System.Drawing.Point(23, 184);
            this.label_impostodist.Name = "label_impostodist";
            this.label_impostodist.Size = new System.Drawing.Size(361, 39);
            this.label_impostodist.TabIndex = 2;
            this.label_impostodist.Text = "Imposto do distribuidor";
            this.label_impostodist.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_impostos
            // 
            this.label_impostos.AutoSize = true;
            this.label_impostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_impostos.Location = new System.Drawing.Point(23, 244);
            this.label_impostos.Name = "label_impostos";
            this.label_impostos.Size = new System.Drawing.Size(155, 39);
            this.label_impostos.TabIndex = 3;
            this.label_impostos.Text = "Impostos";
            // 
            // label_imp28
            // 
            this.label_imp28.AutoSize = true;
            this.label_imp28.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imp28.Location = new System.Drawing.Point(403, 184);
            this.label_imp28.Name = "label_imp28";
            this.label_imp28.Size = new System.Drawing.Size(85, 39);
            this.label_imp28.TabIndex = 4;
            this.label_imp28.Text = "28%";
            this.label_imp28.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label_imp45
            // 
            this.label_imp45.AutoSize = true;
            this.label_imp45.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imp45.Location = new System.Drawing.Point(403, 244);
            this.label_imp45.Name = "label_imp45";
            this.label_imp45.Size = new System.Drawing.Size(85, 39);
            this.label_imp45.TabIndex = 5;
            this.label_imp45.Text = "45%";
            // 
            // label_custofi
            // 
            this.label_custofi.AutoSize = true;
            this.label_custofi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_custofi.Location = new System.Drawing.Point(23, 361);
            this.label_custofi.Name = "label_custofi";
            this.label_custofi.Size = new System.Drawing.Size(178, 39);
            this.label_custofi.TabIndex = 6;
            this.label_custofi.Text = "Custo final";
            this.label_custofi.Click += new System.EventHandler(this.Label1_Click_3);
            // 
            // textBox_custof
            // 
            this.textBox_custof.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_custof.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_custof.Location = new System.Drawing.Point(381, 355);
            this.textBox_custof.Name = "textBox_custof";
            this.textBox_custof.Size = new System.Drawing.Size(158, 45);
            this.textBox_custof.TabIndex = 7;
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(597, 275);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(139, 48);
            this.button_calcular.TabIndex = 9;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.Button_calcular_Click);
            // 
            // button_prox
            // 
            this.button_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prox.Location = new System.Drawing.Point(597, 329);
            this.button_prox.Name = "button_prox";
            this.button_prox.Size = new System.Drawing.Size(139, 48);
            this.button_prox.TabIndex = 10;
            this.button_prox.Text = "Proximo";
            this.button_prox.UseVisualStyleBackColor = true;
            this.button_prox.Click += new System.EventHandler(this.Button_prox_Click);
            // 
            // textBox_custofab
            // 
            this.textBox_custofab.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_custofab.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox_custofab.Location = new System.Drawing.Point(381, 111);
            this.textBox_custofab.Name = "textBox_custofab";
            this.textBox_custofab.Size = new System.Drawing.Size(158, 45);
            this.textBox_custofab.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_custofab);
            this.Controls.Add(this.button_prox);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.textBox_custof);
            this.Controls.Add(this.label_custofi);
            this.Controls.Add(this.label_imp45);
            this.Controls.Add(this.label_imp28);
            this.Controls.Add(this.label_impostos);
            this.Controls.Add(this.label_impostodist);
            this.Controls.Add(this.label_custofab);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_custofab;
        private System.Windows.Forms.Label label_impostodist;
        private System.Windows.Forms.Label label_impostos;
        private System.Windows.Forms.Label label_imp28;
        private System.Windows.Forms.Label label_imp45;
        private System.Windows.Forms.Label label_custofi;
        private System.Windows.Forms.TextBox textBox_custof;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_prox;
        private System.Windows.Forms.TextBox textBox_custofab;
    }
}

