namespace pastelaria_do_tio_zé
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.register_label = new System.Windows.Forms.Label();
            this.register_number = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(5, 27);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(584, 25);
            this.name.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(3, 2);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 21);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Nome";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(5, 83);
            this.cpf_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(42, 21);
            this.cpf_label.TabIndex = 3;
            this.cpf_label.Text = "CPF";
            this.cpf_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpf_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(5, 122);
            this.cpf.Margin = new System.Windows.Forms.Padding(4);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(584, 25);
            this.cpf.TabIndex = 2;
            this.cpf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Location = new System.Drawing.Point(5, 181);
            this.register_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(80, 21);
            this.register_label.TabIndex = 5;
            this.register_label.Text = "Matrícula";
            this.register_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // register_number
            // 
            this.register_number.Location = new System.Drawing.Point(5, 206);
            this.register_number.Margin = new System.Windows.Forms.Padding(4);
            this.register_number.Name = "register_number";
            this.register_number.Size = new System.Drawing.Size(584, 25);
            this.register_number.TabIndex = 4;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(5, 263);
            this.phone_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(73, 21);
            this.phone_label.TabIndex = 7;
            this.phone_label.Text = "Telefone";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(5, 289);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(584, 25);
            this.phone.TabIndex = 6;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(5, 338);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(57, 21);
            this.pass_label.TabIndex = 9;
            this.pass_label.Text = "Senha";
            this.pass_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pass_label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(3, 363);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(584, 25);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "Admin",
            "Balcão"});
            this.group.Location = new System.Drawing.Point(3, 437);
            this.group.Margin = new System.Windows.Forms.Padding(4);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(583, 29);
            this.group.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grupo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(217, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 146);
            this.panel2.TabIndex = 12;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.group);
            this.panelForm.Controls.Add(this.pass_label);
            this.panelForm.Controls.Add(this.password);
            this.panelForm.Controls.Add(this.phone_label);
            this.panelForm.Controls.Add(this.phone);
            this.panelForm.Controls.Add(this.register_label);
            this.panelForm.Controls.Add(this.register_number);
            this.panelForm.Controls.Add(this.cpf_label);
            this.panelForm.Controls.Add(this.cpf);
            this.panelForm.Controls.Add(this.name_label);
            this.panelForm.Controls.Add(this.name);
            this.panelForm.Location = new System.Drawing.Point(14, 158);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(589, 379);
            this.panelForm.TabIndex = 14;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(605, 158);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 379);
            this.vScrollBar1.TabIndex = 31;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(262, 553);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(341, 52);
            this.panelControl.TabIndex = 34;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 628);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "employees";
            this.Text = "Funcionários";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox name;
        private Label name_label;
        private Label cpf_label;
        private TextBox cpf;
        private Label register_label;
        private TextBox register_number;
        private Label phone_label;
        private TextBox phone;
        private Label pass_label;
        private TextBox password;
        private ComboBox group;
        private Label label1;
        private Panel panel2;
        private Panel panelForm;
        private VScrollBar vScrollBar1;
        private Panel panelControl;
    }
}