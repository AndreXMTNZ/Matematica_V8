﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematica_V8
{
    public partial class Devs : Form
    {
        public Devs()
        {
            InitializeComponent();
        }

        private void rgs_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();
            this.Hide();
        }
    }
}
