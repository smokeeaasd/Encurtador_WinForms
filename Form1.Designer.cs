namespace Encurtador
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
            this.label2 = new System.Windows.Forms.Label();
            this.entryLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncurtar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.linkEncurtado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encurtador";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryLink
            // 
            this.entryLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entryLink.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryLink.Location = new System.Drawing.Point(100, 90);
            this.entryLink.Name = "entryLink";
            this.entryLink.Size = new System.Drawing.Size(300, 33);
            this.entryLink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "insira um link acima";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEncurtar
            // 
            this.btnEncurtar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncurtar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.btnEncurtar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncurtar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncurtar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEncurtar.FlatAppearance.BorderSize = 0;
            this.btnEncurtar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncurtar.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnEncurtar.ForeColor = System.Drawing.Color.White;
            this.btnEncurtar.Location = new System.Drawing.Point(100, 175);
            this.btnEncurtar.Name = "btnEncurtar";
            this.btnEncurtar.Size = new System.Drawing.Size(125, 50);
            this.btnEncurtar.TabIndex = 4;
            this.btnEncurtar.Text = "Encurtar";
            this.btnEncurtar.UseVisualStyleBackColor = false;
            this.btnEncurtar.Click += new System.EventHandler(this.btnEncurtar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(275, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 50);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // linkEncurtado
            // 
            this.linkEncurtado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkEncurtado.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.linkEncurtado.ForeColor = System.Drawing.Color.White;
            this.linkEncurtado.Location = new System.Drawing.Point(125, 250);
            this.linkEncurtado.Name = "linkEncurtado";
            this.linkEncurtado.Size = new System.Drawing.Size(250, 30);
            this.linkEncurtado.TabIndex = 7;
            this.linkEncurtado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.linkEncurtado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEncurtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryLink);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entryLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncurtar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label linkEncurtado;
    }
}

