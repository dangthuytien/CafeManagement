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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { "Trà sữa trân châu", 1, 20000, 20000 });
            dataGridView1.Rows.Add(new object[] { "Trà sữa khoai môn", 2, 20000, 40000 });
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
