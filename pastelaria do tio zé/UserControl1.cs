using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pastelaria_do_tio_zé
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            save.FlatStyle = FlatStyle.Flat;
            save.FlatAppearance.BorderSize = 0;
            save.BackColor = ColorTranslator.FromHtml("#37B52C");
            save.Text = "Salvar";

            cancel.FlatStyle = FlatStyle.Flat;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.BackColor = ColorTranslator.FromHtml("#ff0000");
            cancel.Text = "Cancelar";
        }
    }
}
