using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            item it = new item();
            it.number = Convert.ToInt32(txt_num.Text);
            it.Name = txtName.Text;
            it.price = Convert.ToDouble(txtPrice.Text);
            it.quantity = Convert.ToInt32(txtQty.Text);
            it.date = dateTimePicker1.Text;
            it.inventoryNumber = Convert.ToInt32(txt_InventoryNum.Text);
            MessageBox.Show("Saved " + it.date);
            
        }
    }
}
