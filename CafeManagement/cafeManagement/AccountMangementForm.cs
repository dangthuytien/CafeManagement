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
    public partial class AccountMangementForm : Form
    {
        public AccountMangementForm()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form addNewAccount = new AddNewAccountForm();
            addNewAccount.Show();
        }

        private void AccountMangementForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Admin","123456","Admin","Admin");
            dataGridView1.Rows.Add("lequangtai","123456","Lê Quang Tài","Employee");

        }
    }
}
