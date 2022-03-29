namespace pastelaria_do_tio_zé
{
    partial class UserControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.save.Location = new System.Drawing.Point(111, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 52);
            this.save.TabIndex = 0;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel.Location = new System.Drawing.Point(3, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(102, 52);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(221, 52);
            this.ResumeLayout(false);

        }

        #endregion
        public Button save;
        public Button cancel;
    }
}
