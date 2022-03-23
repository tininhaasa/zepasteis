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
            this.percent_label = new System.Windows.Forms.Label();
            this.percent_value = new System.Windows.Forms.TextBox();
            this.forfeit = new System.Windows.Forms.TextBox();
            this.forfeit_label = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percent_label
            // 
            resources.ApplyResources(this.percent_label, "percent_label");
            this.percent_label.Name = "percent_label";
            this.percent_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // percent_value
            // 
            resources.ApplyResources(this.percent_value, "percent_value");
            this.percent_value.Name = "percent_value";
            // 
            // forfeit
            // 
            resources.ApplyResources(this.forfeit, "forfeit");
            this.forfeit.Name = "forfeit";
            // 
            // forfeit_label
            // 
            resources.ApplyResources(this.forfeit_label, "forfeit_label");
            this.forfeit_label.Name = "forfeit_label";
            this.forfeit_label.Click += new System.EventHandler(this.forfeit_label_Click);
            // 
            // save
            // 
            resources.ApplyResources(this.save, "save");
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // config
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save);
            this.Controls.Add(this.forfeit_label);
            this.Controls.Add(this.forfeit);
            this.Controls.Add(this.percent_value);
            this.Controls.Add(this.percent_label);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label percent_label;
        private TextBox percent_value;
        private TextBox forfeit;
        private Label forfeit_label;
        private Button save;
    }
}