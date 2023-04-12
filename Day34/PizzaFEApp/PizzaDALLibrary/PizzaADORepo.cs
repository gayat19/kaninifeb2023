using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALLibrary
{
    public class PizzaADORepo : IRepo<Pizza, int>
    {
        SqlConnection conn;
        public PizzaADORepo()
        {
            
            conn = new SqlConnection(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbPizzaStore12Apr2023");
        }
        public Pizza Add(Pizza item)
        {
            SqlCommand cmdInsert = new SqlCommand("proc_InsertPIzza", conn);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@pname", item.Name);
            cmdInsert.Parameters.AddWithValue("@pprice", (float)item.Price);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            int result = cmdInsert.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                conn.Open();
                cmdInsert = new SqlCommand("proc_GetLatestId", conn);
                item.Id = Convert.ToInt32(cmdInsert.ExecuteScalar().ToString());
                conn.Close();
                return item;
            }
            return null;
        }

        public Pizza Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pizza> GetAll()
        {
            List<Pizza> pizzas = new List<Pizza>();
            SqlCommand cmdSelect = new SqlCommand("proc_GetAllPizzas", conn);
            cmdSelect.CommandType = CommandType.StoredProcedure;
            conn.Open();
            Pizza pizza;
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (!reader.HasRows)
                return null;
            while (reader.Read()) { 
                pizza = new Pizza();
                pizza.Id = Convert.ToInt32(reader[0].ToString());
                pizza.Name = reader[1].ToString();
                pizza.Price = Convert.ToDouble(reader[2].ToString());
                pizzas.Add(pizza);
            }
            conn.Close();
            return pizzas;
        }
    }
}
