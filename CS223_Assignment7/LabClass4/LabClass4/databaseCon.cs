using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabClass4
{
    public partial class databaseCon : Form
    {
        public databaseCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string testString = "pdated";
            
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=test;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //  string sqlQuery = "update t set name = '"+testString+"' where name like '"+"e%"+"'";
                    string sqlQuery = "Insert into t values()";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element
                    while (result.Read()) // iterate each row
                    {
                        /*   result[0] returns first column of first row
                           result[1] returns second column of first row
                            .
                            .
                            .   
                       */
                    }
                    con.Close();

                    MessageBox.Show($"Connection Succesfull\n {result} rows affected");

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect!");
            }

        }
    }
}
