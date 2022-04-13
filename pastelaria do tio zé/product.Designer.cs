namespace pastelaria_do_tio_zé
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.description_label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.product_image = new System.Windows.Forms.PictureBox();
            this.panelControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(350, 68);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(512, 25);
            this.name.TabIndex = 14;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(350, 43);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 21);
            this.name_label.TabIndex = 15;
            this.name_label.Text = "Nome";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price_label
            // 
            this.price_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(350, 129);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(53, 21);
            this.price_label.TabIndex = 17;
            this.price_label.Text = "Preço";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.price.Location = new System.Drawing.Point(350, 154);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(512, 25);
            this.price.TabIndex = 16;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(350, 232);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(515, 25);
            this.description.TabIndex = 18;
            // 
            // description_label1
            // 
            this.description_label1.AutoSize = true;
            this.description_label1.Location = new System.Drawing.Point(350, 207);
            this.description_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label1.Name = "description_label1";
            this.description_label1.Size = new System.Drawing.Size(82, 21);
            this.description_label1.TabIndex = 19;
            this.description_label1.Text = "Descrição";
            this.description_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // product_image
            // 
            this.product_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("product_image.BackgroundImage")));
            this.product_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.product_image.Location = new System.Drawing.Point(56, 49);
            this.product_image.Margin = new System.Windows.Forms.Padding(4);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(261, 249);
            this.product_image.TabIndex = 20;
            this.product_image.TabStop = false;
            this.product_image.Click += new System.EventHandler(this.product_image_Click);
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(525, 315);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(337, 50);
            this.panelControl.TabIndex = 33;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 391);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.product_image);
            this.Controls.Add(this.description_label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "product";
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox name;
        private Label name_label;
        private Label price_label;
        private TextBox price;
        private TextBox description;
        private Label description_label1;
        private OpenFileDialog openFileDialog1;
        private PictureBox product_image;
        private Panel panelControl;
    }
}