﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void métodoDeLaBisecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBiseccion form = new FormBiseccion();
            form.Owner = this;
            form.ShowDialog();
        }

        private void métodoDeLaReglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReglaFalsa form = new FormReglaFalsa();
            form.Owner = this;
            form.ShowDialog();
        }

        private void métodoNewtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewtonRaphson form = new FormNewtonRaphson();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
