using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace LabClass4
{
    public partial class mainPage : Form
    {
        public mainPage(String user)
        {
            InitializeComponent();
            label7.Text = "User: " + user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //try catch, regular expresion, and if statement validation all 3
            
            Regex checkPrice = new Regex(@"^[0-9]+.[0-9]{2}$");
            Regex checkNumber = new Regex(@"^[0-9]+$");
            
            if(!(checkNumber.IsMatch(txt_Quantity.Text) || checkNumber.IsMatch(txt_InventoryNumber.Text) || checkPrice.IsMatch(txt_Price.Text) || checkNumber.IsMatch(txt_Number.Text)))
            {
                if (!checkPrice.IsMatch(txt_Price.Text))
                {
                    errorProvider1.SetError(txt_Price, "Error: Price should be 4 digit number!");
                }
                else
                {
                    errorProvider1.SetError(txt_Price, "");
                }
                if (!checkNumber.IsMatch(txt_Number.Text))
                {
                    errorProvider1.SetError(txt_Number, "Error: Number should be 4 digit!");
                }
                else
                {
                    errorProvider1.SetError(txt_Number, "");
                }

                if (!checkNumber.IsMatch(txt_Quantity.Text))
                {
                    errorProvider1.SetError(txt_Quantity, "Error: Quantity should not exceed 9999 or be less than 1");
                }
                else
                {
                    errorProvider1.SetError(txt_ItemName, "");
                }
                if (string.IsNullOrEmpty(txt_ItemName.Text))
                {
                    errorProvider1.SetError(txt_ItemName, "Error: Name  input is required");
                }
                else
                {
                    errorProvider1.SetError(txt_ItemName, "");
                }

                if (txt_ItemName.Text.Length < 3)
                {
                    errorProvider1.SetError(txt_ItemName, "Item name is short!");
                }
                else
                {
                    errorProvider1.SetError(txt_ItemName, "");
                }
                if (string.IsNullOrEmpty(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Inventory Number is required");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }
                if (!checkNumber.IsMatch(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Error: !");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }
                if (!checkNumber.IsMatch(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Error: Inventory number should be 4 digit!");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }

            }
            /*
            if (string.IsNullOrEmpty(txt_Number.Text) )
            {
                errorProvider1.SetError( txt_Number, "Number is required!");
            }
            else
            {
                errorProvider1.Clear();
            }
           
            if(string.IsNullOrEmpty(txt_Date.Text) )
            {
                errorProvider1.SetError(txt_Date, "Date is required!");
            }
            else
            {
                errorProvider1.Clear();
            }
            
            if ( string.IsNullOrEmpty(txt_InventoryNumber.Text) )
            {
                errorProvider1.SetError(txt_InventoryNumber, "Inventory No is required!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if ( string.IsNullOrEmpty(txt_ItemName.Text) )
            {
                errorProvider1.SetError(txt_ItemName, "Item Name is required!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if(string.IsNullOrEmpty(txt_Quantity.Text) )
            {
                errorProvider1.SetError(txt_Quantity, "Quantity is required!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if(string.IsNullOrEmpty(txt_Price.Text))
            {
                errorProvider1.SetError(txt_Price, "Price is required!");
            }
            else
            {
                errorProvider1.Clear();
            }
                
            if (txt_ItemName.Text.Length < 3)
            {
                errorProvider1.SetError(txt_ItemName, "Item name is short!");
            }*/
            else
            {
             //   errorProvider.Clear();
                item item1 = new item();
                item1.number = Convert.ToInt32(txt_Number.Text);
                item1.date = txt_Date.Text;
                item1.inventoryNumber = Convert.ToInt32(txt_InventoryNumber.Text);
                item1.itemName = txt_ItemName.Text;
                item1.quantity = Convert.ToInt32(txt_Quantity.Text);
                item1.price = Convert.ToDouble(txt_Price.Text);
                if (rb_av.Checked)
                    item1.availability = rb_av.Text;
                else
                    item1.availability = rb_unav.Text;

                foreach (var i in optionalService.CheckedItems)
                    item1.checkLBox += i.ToString() + "\n";
               
                Boolean b = item1.Save();
                if (b)
                    MessageBox.Show("Connection Succesful!");
                else
                    MessageBox.Show("Unable to connect");
          
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = item.GetAllItems();
                //MessageBox.Show($"Item Has been Added! \n Item number: {item1.number}\n Item date: {item1.date}\n Inventory number: {item1.inventoryNumber}\n Item name: {item1.itemName}\n Quantity: {item1.quantity}\n Price: {item1.price} ");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_av_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
