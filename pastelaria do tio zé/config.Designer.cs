namespace pastelaria_do_tio_zé
{
    partial class config
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
            this.save = new System.Windows.Forms.Button();
            this.forfeit_label = new System.Windows.Forms.Label();
            this.forfeit = new System.Windows.Forms.TextBox();
            this.percent_value = new System.Windows.Forms.TextBox();
            this.percent_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(136, 167);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(108, 54);
            this.save.TabIndex = 33;
            this.save.Text = "SALVAR";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // forfeit_label
            // 
            this.forfeit_label.AutoSize = true;
            this.forfeit_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forfeit_label.Location = new System.Drawing.Point(12, 91);
            this.forfeit_label.Name = "forfeit_label";
            this.forfeit_label.Size = new System.Drawing.Size(141, 15);
            this.forfeit_label.TabIndex = 32;
            this.forfeit_label.Text = "Valor da Multa por Atraso";
            // 
            // forfeit
            // 
            this.forfeit.Location = new System.Drawing.Point(12, 115);
            this.forfeit.Name = "forfeit";
            this.forfeit.Size = new System.Drawing.Size(232, 23);
            this.forfeit.TabIndex = 31;
            // 
            // percent_value
            // 
            this.percent_value.Location = new System.Drawing.Point(12, 43);
            this.percent_value.Name = "percent_value";
            this.percent_value.Size = new System.Drawing.Size(232, 23);
            this.percent_value.TabIndex = 30;
            // 
            // percent_label
            // 
            this.percent_label.AutoSize = true;
            this.percent_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.percent_label.Location = new System.Drawing.Point(12, 19);
            this.percent_label.Name = "percent_label";
            this.percent_label.Size = new System.Drawing.Size(163, 15);
            this.percent_label.TabIndex = 29;
            this.percent_label.Text = "Porcentagem de juros por dia";
            // 
            // configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 239);
            this.Controls.Add(this.save);
            this.Controls.Add(this.forfeit_label);
            this.Controls.Add(this.forfeit);
            this.Controls.Add(this.percent_value);
            this.Controls.Add(this.percent_label);
            this.Name = "configuration";
            this.Text = "configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button save;
        private Label forfeit_label;
        private TextBox forfeit;
        private TextBox percent_value;
        private Label percent_label;
    }
}