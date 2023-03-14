using System.Linq;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Add(11, "Trà sữa trân châu", "Trà sữa", 20000);
            dataGridView1.Rows.Add(12, "Trà sữa Khoai môn", "Trà sữa", 20000);
            dataGridView1.Rows.Add(13, "Trà sữa việt quất", "Trà sữa", 20000);
            dataGridView1.Rows.Add(14, "Trà sữa socola"   , "Trà sữa", 20000);
            dataGridView1.Rows.Add(21, "Cà phê đá", "Cà phê", 15000);
            dataGridView1.Rows.Add(22, "Cà phê sữa", "Cà phê", 17000);
            dataGridView1.Rows.Add(31, "Soda chanh dây", "Soda", 20000);
            dataGridView1.Rows.Add(32, "Soda việt quất", "Soda", 20000);
            dataGridView1.Rows.Add(33, "Soda kem cheese", "Soda", 20000);
            dataGridView1.Rows.Add(41, "Heineken", "Soda", 30000);
            dataGridView1.Rows.Add(42, "Saigon Special", "Soda", 25000);

        }

        private void bunifuTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, System.EventArgs e)
        {
            Form category = new CategoryForm();
            category.Show();
          //  var control = Application.OpenForms.Cast<ControlForm>().Last(); // using LINQ 
        } 

        private void bunifuButton2_Click(object sender, System.EventArgs e)
        {
            Form addNew = new AddNewObject();
            addNew.Show();
        }
    }
}