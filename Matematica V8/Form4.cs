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
    public partial class rkreamer : Form
    {
        public rkreamer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu ventanamain = new Menu();
            ventanamain.Show();
            this.Hide();
        }

        private void botoncalc_Click(object sender, EventArgs e)
        {

        }
    }
}
