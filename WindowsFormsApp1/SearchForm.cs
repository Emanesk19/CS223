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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            bool found = i.find(textBox1.Text);
            if ( found== true)
            {
                MessageBox.Show("Product Found ");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.getAllProduct();

            }
            else
            {
                MessageBox.Show("Product Not Found ");

            }

        }
    }
}
