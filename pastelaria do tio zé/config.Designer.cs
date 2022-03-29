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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.forfeit_label = new System.Windows.Forms.Label();
            this.forfeit = new System.Windows.Forms.TextBox();
            this.percent_value = new System.Windows.Forms.TextBox();
            this.percent_label = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // forfeit_label
            // 
            this.forfeit_label.AutoSize = true;
            this.forfeit_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forfeit_label.Location = new System.Drawing.Point(18, 109);
            this.forfeit_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forfeit_label.Name = "forfeit_label";
            this.forfeit_label.Size = new System.Drawing.Size(209, 22);
            this.forfeit_label.TabIndex = 32;
            this.forfeit_label.Text = "Valor da Multa por Atraso";
            // 
            // forfeit
            // 
            this.forfeit.Location = new System.Drawing.Point(18, 153);
            this.forfeit.Margin = new System.Windows.Forms.Padding(4);
            this.forfeit.Name = "forfeit";
            this.forfeit.Size = new System.Drawing.Size(330, 27);
            this.forfeit.TabIndex = 31;
            // 
            // percent_value
            // 
            this.percent_value.Location = new System.Drawing.Point(18, 63);
            this.percent_value.Margin = new System.Windows.Forms.Padding(4);
            this.percent_value.Name = "percent_value";
            this.percent_value.Size = new System.Drawing.Size(330, 27);
            this.percent_value.TabIndex = 30;
            // 
            // percent_label
            // 
            this.percent_label.AutoSize = true;
            this.percent_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.percent_label.Location = new System.Drawing.Point(18, 28);
            this.percent_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percent_label.Name = "percent_label";
            this.percent_label.Size = new System.Drawing.Size(248, 22);
            this.percent_label.TabIndex = 29;
            this.percent_label.Text = "Porcentagem de juros por dia";
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(18, 208);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(330, 52);
            this.panelControl.TabIndex = 34;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint_1);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 291);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.forfeit_label);
            this.Controls.Add(this.forfeit);
            this.Controls.Add(this.percent_value);
            this.Controls.Add(this.percent_label);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "config";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label forfeit_label;
        private TextBox forfeit;
        private TextBox percent_value;
        private Label percent_label;
        private Panel panelControl;
    }
}