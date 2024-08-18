namespace Aprendendo_sobre_DLL_unimake
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTNconsultaSuutatus = new System.Windows.Forms.Button();
            this.BTNconsultaSituação = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NFE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 22);
            this.textBox2.TabIndex = 2;
            // 
            // BTNconsultaSuutatus
            // 
            this.BTNconsultaSuutatus.Location = new System.Drawing.Point(85, 186);
            this.BTNconsultaSuutatus.Name = "BTNconsultaSuutatus";
            this.BTNconsultaSuutatus.Size = new System.Drawing.Size(199, 23);
            this.BTNconsultaSuutatus.TabIndex = 3;
            this.BTNconsultaSuutatus.Text = "Consulta Status";
            this.BTNconsultaSuutatus.UseVisualStyleBackColor = true;
            this.BTNconsultaSuutatus.Click += new System.EventHandler(this.BTNconsultaSuutatus_Click);
            // 
            // BTNconsultaSituação
            // 
            this.BTNconsultaSituação.Location = new System.Drawing.Point(85, 215);
            this.BTNconsultaSituação.Name = "BTNconsultaSituação";
            this.BTNconsultaSituação.Size = new System.Drawing.Size(199, 23);
            this.BTNconsultaSituação.TabIndex = 4;
            this.BTNconsultaSituação.Text = "Consulta Situação";
            this.BTNconsultaSituação.UseVisualStyleBackColor = true;
            this.BTNconsultaSituação.Click += new System.EventHandler(this.BTNconsultaSituação_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNconsultaSituação);
            this.Controls.Add(this.BTNconsultaSuutatus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTNconsultaSuutatus;
        private System.Windows.Forms.Button BTNconsultaSituação;
    }
}

