namespace pastelaria_do_tio_zé
{
    partial class ZePasteis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZePasteis));
            this.menu_aside = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.conf = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.functionary = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.menu_nav = new System.Windows.Forms.Panel();
            this.language_en = new System.Windows.Forms.Button();
            this.language_sp = new System.Windows.Forms.Button();
            this.language_pt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu_aside.SuspendLayout();
            this.menu_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_aside
            // 
            this.menu_aside.Controls.Add(this.about);
            this.menu_aside.Controls.Add(this.conf);
            this.menu_aside.Controls.Add(this.product);
            this.menu_aside.Controls.Add(this.clients);
            this.menu_aside.Controls.Add(this.functionary);
            this.menu_aside.Controls.Add(this.login);
            this.menu_aside.Location = new System.Drawing.Point(0, 62);
            this.menu_aside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu_aside.Name = "menu_aside";
            this.menu_aside.Size = new System.Drawing.Size(207, 539);
            this.menu_aside.TabIndex = 0;
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(0, 301);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(207, 42);
            this.about.TabIndex = 5;
            this.about.Text = "Sobre";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // conf
            // 
            this.conf.Location = new System.Drawing.Point(1, 252);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(205, 43);
            this.conf.TabIndex = 4;
            this.conf.Text = "Configuração";
            this.conf.UseVisualStyleBackColor = true;
            this.conf.Click += new System.EventHandler(this.conf_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.product.Location = new System.Drawing.Point(0, 204);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(207, 42);
            this.product.TabIndex = 3;
            this.product.Text = "Produtos";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(0, 158);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(207, 40);
            this.clients.TabIndex = 2;
            this.clients.Text = "Clientes";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // functionary
            // 
            this.functionary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.functionary.Location = new System.Drawing.Point(0, 106);
            this.functionary.Name = "functionary";
            this.functionary.Size = new System.Drawing.Size(206, 46);
            this.functionary.TabIndex = 1;
            this.functionary.Text = "Funcionario";
            this.functionary.UseVisualStyleBackColor = false;
            this.functionary.Click += new System.EventHandler(this.functionary_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(0, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(207, 44);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // menu_nav
            // 
            this.menu_nav.Controls.Add(this.language_en);
            this.menu_nav.Controls.Add(this.language_sp);
            this.menu_nav.Controls.Add(this.language_pt);
            this.menu_nav.Controls.Add(this.panel2);
            this.menu_nav.Location = new System.Drawing.Point(0, 0);
            this.menu_nav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu_nav.Name = "menu_nav";
            this.menu_nav.Size = new System.Drawing.Size(978, 65);
            this.menu_nav.TabIndex = 1;
            // 
            // language_en
            // 
            this.language_en.BackColor = System.Drawing.SystemColors.Control;
            this.language_en.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("language_en.BackgroundImage")));
            this.language_en.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.language_en.Location = new System.Drawing.Point(911, 12);
            this.language_en.Name = "language_en";
            this.language_en.Size = new System.Drawing.Size(52, 40);
            this.language_en.TabIndex = 8;
            this.language_en.UseVisualStyleBackColor = false;
            // 
            // language_sp
            // 
            this.language_sp.BackColor = System.Drawing.SystemColors.Control;
            this.language_sp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("language_sp.BackgroundImage")));
            this.language_sp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.language_sp.Location = new System.Drawing.Point(849, 12);
            this.language_sp.Name = "language_sp";
            this.language_sp.Size = new System.Drawing.Size(56, 40);
            this.language_sp.TabIndex = 7;
            this.language_sp.UseVisualStyleBackColor = false;
            // 
            // language_pt
            // 
            this.language_pt.BackColor = System.Drawing.SystemColors.Control;
            this.language_pt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("language_pt.BackgroundImage")));
            this.language_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.language_pt.Location = new System.Drawing.Point(787, 12);
            this.language_pt.Name = "language_pt";
            this.language_pt.Size = new System.Drawing.Size(56, 40);
            this.language_pt.TabIndex = 6;
            this.language_pt.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, -17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 104);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ZePasteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 600);
            this.Controls.Add(this.menu_nav);
            this.Controls.Add(this.menu_aside);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZePasteis";
            this.Text = "Zé Pasteis";
            this.Load += new System.EventHandler(this.ZePasteis_Load);
            this.menu_aside.ResumeLayout(false);
            this.menu_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menu_aside;
        private Panel menu_nav;
        private Button about;
        private Button conf;
        private Button product;
        private Button clients;
        private Button functionary;
        private Button login;
        private Panel panel2;
        private Button language_pt;
        private Button language_sp;
        private Button language_en;
    }
}