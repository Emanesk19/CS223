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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item i = new Item();

            if(i.find(txtName.Text) == true)
            {
                Item.updateProductPrice(txtName.Text, (txtPrice.Text).ToString());
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.getAllProduct();
                MessageBox.Show(Item.res + "  Row Updated ");
            }
            else
            {
                MessageBox.Show(Item.res + " Row Updated ");

            }


        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Item.getAllProduct();
        }
    }
}
