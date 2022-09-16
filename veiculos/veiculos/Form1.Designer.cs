namespace veiculos
{
    partial class frmmenu
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
            this.btncar = new System.Windows.Forms.Button();
            this.btncami = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncar
            // 
            this.btncar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncar.Location = new System.Drawing.Point(193, 203);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(120, 50);
            this.btncar.TabIndex = 0;
            this.btncar.Text = "Carros";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btncami
            // 
            this.btncami.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncami.Location = new System.Drawing.Point(426, 203);
            this.btncami.Name = "btncami";
            this.btncami.Size = new System.Drawing.Size(120, 50);
            this.btncami.TabIndex = 1;
            this.btncami.Text = "Caminhões";
            this.btncami.UseVisualStyleBackColor = true;
            this.btncami.Click += new System.EventHandler(this.btncami_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(588, 370);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(80, 30);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncami);
            this.Controls.Add(this.btncar);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btncami;
        private System.Windows.Forms.Button btnsair;
    }
}

