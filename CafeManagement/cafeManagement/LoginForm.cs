using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class LoginForm : Form
    {
        public bool isAllowToAccess { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signInLabel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            isAllowToAccess = true;
            this.Close();
        }
                  
    }
}
