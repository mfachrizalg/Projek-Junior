﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPage
{
    public partial class FormHomePenjual : Form
    {
        public FormHomePenjual()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfilPenjual formProfilPenjual = new FormProfilPenjual();
            formProfilPenjual.Show();
        }
    }
}