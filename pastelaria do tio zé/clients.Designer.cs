namespace pastelaria_do_tio_zé
{
    partial class clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            this.panel2 = new System.Windows.Forms.Panel();
            this.fine_label = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.ComboBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.register_label = new System.Windows.Forms.Label();
            this.register_number = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.days_label = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(234, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 146);
            this.panel2.TabIndex = 25;
            // 
            // fine_label
            // 
            this.fine_label.AutoSize = true;
            this.fine_label.Location = new System.Drawing.Point(6, 390);
            this.fine_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fine_label.Name = "fine_label";
            this.fine_label.Size = new System.Drawing.Size(79, 21);
            this.fine_label.TabIndex = 24;
            this.fine_label.Text = "Faz fiado";
            this.fine_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.group.Location = new System.Drawing.Point(6, 415);
            this.group.Margin = new System.Windows.Forms.Padding(4);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(583, 29);
            this.group.TabIndex = 23;
            this.group.SelectedValueChanged += new System.EventHandler(this.group_SelectedValueChanged);
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(8, 316);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(57, 21);
            this.pass_label.TabIndex = 22;
            this.pass_label.Text = "Senha";
            this.pass_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(6, 341);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(584, 25);
            this.password.TabIndex = 21;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(8, 242);
            this.phone_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(73, 21);
            this.phone_label.TabIndex = 20;
            this.phone_label.Text = "Telefone";
            this.phone_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(8, 267);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(584, 25);
            this.phone.TabIndex = 19;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Location = new System.Drawing.Point(8, 159);
            this.register_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(80, 21);
            this.register_label.TabIndex = 18;
            this.register_label.Text = "Matrícula";
            this.register_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // register_number
            // 
            this.register_number.Location = new System.Drawing.Point(8, 184);
            this.register_number.Margin = new System.Windows.Forms.Padding(4);
            this.register_number.Name = "register_number";
            this.register_number.Size = new System.Drawing.Size(584, 25);
            this.register_number.TabIndex = 17;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(8, 61);
            this.cpf_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(42, 21);
            this.cpf_label.TabIndex = 16;
            this.cpf_label.Text = "CPF";
            this.cpf_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(8, 100);
            this.cpf.Margin = new System.Windows.Forms.Padding(4);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(584, 25);
            this.cpf.TabIndex = 15;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(4, 7);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 21);
            this.name_label.TabIndex = 14;
            this.name_label.Text = "Nome";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 32);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(584, 25);
            this.name.TabIndex = 13;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(479, 752);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(143, 62);
            this.save.TabIndex = 26;
            this.save.Text = "SALVAR";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // days_label
            // 
            this.days_label.AutoSize = true;
            this.days_label.Location = new System.Drawing.Point(7, 458);
            this.days_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(84, 21);
            this.days_label.TabIndex = 28;
            this.days_label.Text = "Dias fiado";
            this.days_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.days_label.Visible = false;
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(4, 483);
            this.days.Margin = new System.Windows.Forms.Padding(4);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(584, 25);
            this.days.TabIndex = 29;
            this.days.Visible = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(630, 173);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 394);
            this.vScrollBar1.TabIndex = 30;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.days);
            this.panelForm.Controls.Add(this.days_label);
            this.panelForm.Controls.Add(this.fine_label);
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
            this.panelForm.Location = new System.Drawing.Point(28, 173);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(599, 394);
            this.panelForm.TabIndex = 31;
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(261, 588);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(366, 52);
            this.panelControl.TabIndex = 32;
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 672);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "clients";
            this.Text = "clients";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label fine_label;
        private ComboBox group;
        private Label pass_label;
        private TextBox password;
        private Label phone_label;
        private TextBox phone;
        private Label register_label;
        private TextBox register_number;
        private Label cpf_label;
        private TextBox cpf;
        private Label name_label;
        private TextBox name;
        private Button save;
        private Label days_label;
        private TextBox days;
        private VScrollBar vScrollBar1;
        private Panel panelForm;
        private Panel panelControl;
    }
}