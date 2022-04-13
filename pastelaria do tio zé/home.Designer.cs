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
            this.login = new FontAwesome.Sharp.IconButton();
            this.about = new FontAwesome.Sharp.IconButton();
            this.config = new FontAwesome.Sharp.IconButton();
            this.product = new FontAwesome.Sharp.IconButton();
            this.clients = new FontAwesome.Sharp.IconButton();
            this.functionary = new FontAwesome.Sharp.IconButton();
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
            this.menu_aside.Controls.Add(this.login);
            this.menu_aside.Controls.Add(this.about);
            this.menu_aside.Controls.Add(this.config);
            this.menu_aside.Controls.Add(this.product);
            this.menu_aside.Controls.Add(this.clients);
            this.menu_aside.Controls.Add(this.functionary);
            this.menu_aside.Location = new System.Drawing.Point(0, 62);
            this.menu_aside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu_aside.Name = "menu_aside";
            this.menu_aside.Size = new System.Drawing.Size(207, 539);
            this.menu_aside.TabIndex = 0;
            // 
            // login
            // 
            this.login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.login.IconColor = System.Drawing.Color.Black;
            this.login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.login.IconSize = 30;
            this.login.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.login.Location = new System.Drawing.Point(0, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 47);
            this.login.TabIndex = 11;
            this.login.Text = "Entrar";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // about
            // 
            this.about.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.about.IconColor = System.Drawing.Color.Black;
            this.about.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.about.IconSize = 30;
            this.about.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.about.Location = new System.Drawing.Point(0, 492);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(203, 47);
            this.about.TabIndex = 10;
            this.about.Text = "Sobre";
            this.about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // config
            // 
            this.config.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.config.IconColor = System.Drawing.Color.Black;
            this.config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.config.IconSize = 30;
            this.config.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.config.Location = new System.Drawing.Point(1, 248);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(203, 47);
            this.config.TabIndex = 9;
            this.config.Text = "Configuração";
            this.config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.conf_Click);
            // 
            // product
            // 
            this.product.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.product.IconColor = System.Drawing.Color.Black;
            this.product.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.product.IconSize = 30;
            this.product.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.product.Location = new System.Drawing.Point(0, 199);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(203, 47);
            this.product.TabIndex = 8;
            this.product.Text = "Produtos";
            this.product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // clients
            // 
            this.clients.IconChar = FontAwesome.Sharp.IconChar.User;
            this.clients.IconColor = System.Drawing.Color.Black;
            this.clients.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.clients.IconSize = 28;
            this.clients.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.clients.Location = new System.Drawing.Point(0, 151);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(203, 47);
            this.clients.TabIndex = 7;
            this.clients.Text = "Clientes";
            this.clients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // functionary
            // 
            this.functionary.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.functionary.IconColor = System.Drawing.Color.Black;
            this.functionary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.functionary.IconSize = 30;
            this.functionary.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.functionary.Location = new System.Drawing.Point(0, 105);
            this.functionary.Name = "functionary";
            this.functionary.Size = new System.Drawing.Size(203, 47);
            this.functionary.TabIndex = 6;
            this.functionary.Text = "Funcionários";
            this.functionary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.functionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.functionary.UseVisualStyleBackColor = true;
            this.functionary.Click += new System.EventHandler(this.functionary_Click);
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
            this.language_en.Click += new System.EventHandler(this.language_en_Click);
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
            this.language_sp.Click += new System.EventHandler(this.language_sp_Click);
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
            this.language_pt.Click += new System.EventHandler(this.language_pt_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, -17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 104);
            this.panel2.TabIndex = 5;
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
        private Panel panel2;
        private Button language_pt;
        private Button language_sp;
        private Button language_en;
        private FontAwesome.Sharp.IconButton functionary;
        private FontAwesome.Sharp.IconButton clients;
        private FontAwesome.Sharp.IconButton product;
        private FontAwesome.Sharp.IconButton config;
        private FontAwesome.Sharp.IconButton about;
        private FontAwesome.Sharp.IconButton login;
    }
}