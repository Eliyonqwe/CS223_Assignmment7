using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClass4
{
    internal class item
    {
        

        static List<item> i = new List<item>();
        public int number { get; set; }
        public String date { get; set; }
        public int inventoryNumber { get; set; }
        public String itemName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string availability { get; set; }
        public String checkLBox { get; set; }

        public Boolean Save()
        {
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=test;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlQuery = "insert into product values(@num, @date, @in_no,@name,@quan, @price)";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@num", this.number);
                    cmd.Parameters.AddWithValue("@date", this.date );
                    cmd.Parameters.AddWithValue("@in_no", this.inventoryNumber);
                    cmd.Parameters.AddWithValue("@name", this.itemName);
                    cmd.Parameters.AddWithValue("@quan", this.quantity);
                    cmd.Parameters.AddWithValue("@price", this.price);
                    var result = cmd.ExecuteNonQuery(); // returns row affected, executescalar for single element    
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          }
        public static List<item> GetAllItems()
        {
            
            try
            {
                String conString = @"Data Source=DESKTOP-49EQ2RG;Initial Catalog=test;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    
                    string sqlQuery = "select *from product";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    var result = cmd.ExecuteReader(); // returns row affected, executescalar for single element(preferebally a row)    
                    while (result.Read())
                    {
                        item itm = new item();
                        itm.number = Convert.ToInt32(result[1]);
                        itm.date = result[2].ToString();
                        itm.inventoryNumber = Convert.ToInt32(result[3]);
                        itm.itemName = result[4].ToString();
                        itm.quantity = Convert.ToInt32(result[5]);
                        itm.price = Convert.ToInt32(result[6]);
                        item.i.Add(itm);
                    }
                }
                return item.i;
            }
            catch (Exception)
            {
                return item.i; 
            }
            
        }
    }
}
