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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
               
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form opened = this.ActiveMdiChild;
            if (opened != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 display = new Form1();
            display.MdiParent = this;
            display.Show();
        }

        private void getAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Panels pan = new Panels();
            pan.MdiParent = this;
            pan.Show();
            

        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            SearchForm search = new SearchForm();
            search.MdiParent = this;
            search.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Update_Product update_ = new Update_Product();
            update_.MdiParent = this;
            update_.Show();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            DeleteForm delete = new DeleteForm();
            delete.MdiParent = this;
            delete.Show();
        }
    }
}
