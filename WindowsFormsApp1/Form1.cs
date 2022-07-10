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
            item it = new item()
            {
                number = Convert.ToInt32(txt_num.Text),
                Name = txtName.Text,
                price = Convert.ToDouble(txtPrice.Text),
                quantity = Convert.ToInt32(txtQty.Text),
                date = dateTimePicker1.Text,
                inventoryNumber = Convert.ToInt32(txt_InventoryNum.Text),
            };
            it.save();
            MessageBox.Show("Saved " );
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
