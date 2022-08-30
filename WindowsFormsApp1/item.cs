using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Item
    {
       static List<Item> item = new List<Item>();

        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }
        public int result = 0;
       
       static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6QAMF1U;Initial Catalog=c#Database;Integrated Security=True");

        public void save()
        {
            string query1 = "insert into Product " +
                "values(@num,@name ,@qty,@price,@date,@invNum,@available)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.Parameters.AddWithValue("@num", this.number);
            cmd.Parameters.AddWithValue("@name ", this.Name);
            cmd.Parameters.AddWithValue("@qty ", this.quantity);
            cmd.Parameters.AddWithValue("@price ", this.price);
            cmd.Parameters.AddWithValue("@date ", this.date);
            cmd.Parameters.AddWithValue("@invNum ", this.inventoryNumber);
            cmd.Parameters.AddWithValue("@available ", this.isAvailable);
             result = cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public static List<Item> getAllProduct()
        {
            List<Item> it = new List<Item>();

            string query2 = " select *from Product";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query2, conn);
          var res= cmd.ExecuteReader();
            while (res.Read())
            {
                Item i = new Item();
                i.number = Convert.ToInt32(res[0]);
                i.Name = res[1].ToString();
                i.quantity = Convert.ToInt32(res[2]);
                i.price = Convert.ToInt32(res[3]);
                i.date = res[4].ToString();
                i.inventoryNumber = Convert.ToInt32(res[5]);
                i.isAvailable = Convert.ToBoolean(res[6]);
                
                it.Add(i);

            };

            conn.Close();
             return it;
        }
         static public int res = 0;
        public static void updateProductPrice( string proName, string newValue )
        {
            string query3 = "Update Product set Price = @newValue where ProName = @proName";
               
                
             conn.Open();
            SqlCommand cmd = new SqlCommand(query3, conn);
           
            cmd.Parameters.AddWithValue("@newValue ", newValue);
            cmd.Parameters.AddWithValue("@proName ", proName);
            res = cmd.ExecuteNonQuery();
              conn.Close();

        }
        public static void delete(string proName)
        {
            string query4 = "Delete Product where ProName = @proName";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@proName ", proName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public  bool find(string proName)
        {
            List<Item> it = new List<Item>();

            string query5 = " select * from Product where ProName = @name";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query5, conn);
            cmd.Parameters.AddWithValue("@name ", proName);
            SqlDataReader res = cmd.ExecuteReader();
            bool isFound = false;
            while (res.Read())
            {
                Item i = new Item();
                i.number = Convert.ToInt32(res["ProNumber"]);
                i.Name = res["ProName"].ToString();
                i.quantity = Convert.ToInt32(res["quantity"]);
                i.price = Convert.ToDouble(res["price"]);
                i.inventoryNumber = Convert.ToInt32(res["inventoryNumber"]);
                i.date = res["EntryDate"].ToString();
                i.isAvailable = Convert.ToBoolean(res["isAvailable"]);
                isFound = true;
            }
            conn.Close();
            return isFound;
        }
    }
}
