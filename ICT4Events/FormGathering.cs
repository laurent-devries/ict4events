﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events
{
    public partial class FormGathering : Form
    {
        public FormGathering()
        {
            InitializeComponent();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hiresystem h = new Hiresystem();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventBeheerReservering E = new EventBeheerReservering();
            E.Show();
        }


    }
}
    