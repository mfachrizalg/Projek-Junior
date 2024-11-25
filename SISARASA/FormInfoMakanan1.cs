using SISARASA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SISARASA
{
    public partial class FormInfoMakanan1 : Form
    {
        private int _menuId;

        public FormInfoMakanan1(int menuId)
        {
            InitializeComponent();
            _menuId = menuId;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var cartItem = new Keranjang
                {
                    menu_id = _menuId,
                    user_id = UserSession.Id,
                };

                context.Carts.Add(cartItem);
                context.SaveChanges();
            }

            FormCart formCart = new FormCart();
            formCart.Show();
            Visible = false;
            this.Dispose();
        }
    }
}
