using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISARASA
{
    public partial class UserControlKomponenMakanan : UserControl
    {
        public UserControlKomponenMakanan()
        {
            InitializeComponent();
        }

        private void pictBoxMakanan_Click(object sender, EventArgs e)
        {
            FormInfoMakanan1 formInfoMakanan1 = new FormInfoMakanan1();
            formInfoMakanan1.Show();
            Visible = false;
        }

        private void lblMakananUserControl_Click(object sender, EventArgs e)
        {
            FormInfoMakanan1 formInfoMakanan1 = new FormInfoMakanan1();
            formInfoMakanan1.Show();
            Visible = false;
        }
    }
}
