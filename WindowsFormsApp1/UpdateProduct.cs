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
            Item.updateProduct(Convert.ToDouble(txtPrice.Text), txtName.Text);
            MessageBox.Show("Updated ");

        }
    }
}
