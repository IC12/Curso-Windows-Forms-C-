﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCurso
{
    public partial class Frm_MouseCapture : Form
    {
        public Frm_MouseCapture()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();
            MessageBox.Show("Foi pressionado o botão da(o) " + str1);
        }
    }
}
