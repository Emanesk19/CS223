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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text=="admin")
            {
                Form1 displayScreen = new Form1();
                Hide();
                displayScreen.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect Credential");
            }
        }
    }
}
