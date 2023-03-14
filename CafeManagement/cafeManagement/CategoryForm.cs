using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Trà sữa", 4);
            dataGridView1.Rows.Add("Soda", 3);
            dataGridView1.Rows.Add("Alcohol", 2);
            dataGridView1.Rows.Add("Cà phê", 5);
        }
    }
}
