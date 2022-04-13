namespace pastelaria_do_tio_zé
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginField = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.loginField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.loginField, "loginField");
            this.loginField.Name = "loginField";
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // login_label
            // 
            resources.ApplyResources(this.login_label, "login_label");
            this.login_label.Name = "login_label";
            this.login_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass_label
            // 
            resources.ApplyResources(this.pass_label, "pass_label");
            this.pass_label.Name = "pass_label";
            this.pass_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Info;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.loginField);
            this.Name = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginField;
        private Label login_label;
        private Label pass_label;
        private TextBox password;
        private Panel panel1;
        private Button btn_login;
    }
}