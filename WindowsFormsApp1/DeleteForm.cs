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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            if(i.find(txtName.Text) == true)
            {
                Item.delete(txtName.Text);
                MessageBox.Show("Deleted");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.getAllProduct();
            }
           
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Item.getAllProduct();
        }
    }
}
