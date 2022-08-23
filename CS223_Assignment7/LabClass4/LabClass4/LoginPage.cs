using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabClass4
{
    public partial class LoginPage : Form
    {
        public LoginPage() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginDetails l = new LoginDetails();
            if(uname_txt.Text == LoginDetails.username && pass_txt.Text == LoginDetails.password)
            {
                MessageBox.Show("Login Successfull!");
                mainPage n = new mainPage(LoginDetails.username);
                this.Hide();
                n.Show();
                

            }
            else
            {
                MessageBox.Show("Error: Incorrect username or password!");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uname_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
