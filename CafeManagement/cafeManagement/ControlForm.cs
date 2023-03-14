using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class ControlForm : Form
    {
        private Form childFormCheck = null;
        public ControlForm()
        {
            InitializeComponent();
        }
        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            AddChildFormToPanel(new OrderForm());
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {

            AddChildFormToPanel(new OverviewForm());
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddChildFormToPanel(Form childForm)
        {
            if (childFormCheck != null)
            {
                childFormCheck.Close();
            }
            childFormCheck = childForm;
            childForm.TopLevel = false;
            childForm.Parent = this.displayFormPanel;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            AddChildFormToPanel(new MenuForm());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form login = new LoginForm();
            this.Hide();
            login.Closed += (s, args) => this.Close(); 
            login.Show();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AddChildFormToPanel(new AccountMangementForm());
        }
    }
}
