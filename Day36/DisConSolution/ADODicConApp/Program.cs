using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADODicConApp
{
    internal class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial Catalog=dbRecruitApr2023");
            //adapter = new SqlDataAdapter();
            //adapter.SelectCommand = new SqlCommand("Select * from tblUsers");
            //adapter.SelectCommand.Connection = conn;
        }
        void FetchAndDisplayData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from tblUsers", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                Console.WriteLine("Username : " + dataRow[0]);
                Console.WriteLine("Password : " + dataRow["password"]);
                Console.WriteLine("Role : " + dataRow[2]);
                Console.WriteLine("-------------------------");
            }
        }
        void FetchAndDisplayDataUsingSP()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("proc_FetchUSers", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                Console.WriteLine("Username : " + dataRow[0]);
                Console.WriteLine("Password : " + dataRow["password"]);
                Console.WriteLine("Role : " + dataRow[2]);
                Console.WriteLine("-------------------------");
            }
        }
        void AddNewUser()
        {
            string username="", password="", role="";
            Console.WriteLine("Please enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Please enter the role");
            role = Console.ReadLine();
            string insertQuery = "insert into tblUsers values(@un,@pass,@ur)";
            SqlCommand cmd = new SqlCommand(insertQuery,conn);
            //cmd.Parameters.Add("@un", SqlDbType.VarChar, 20);
            //cmd.Parameters[0].Value = username;
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@ur", role);
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("User inserted");
                }
                else
                    Console.WriteLine("User registration failed");
            }
            catch (SqlException se)
            {
                Console.WriteLine("Sql is not wokinga s expected");
                Debug.WriteLine(se.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        void InsertUsingSP()
        {
            string username = "", password = "", role = "";
            Console.WriteLine("Please enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Please enter the role");
            role = Console.ReadLine();
            string insertQuery = "proc_InsertUser";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@upass", password);
            cmd.Parameters.AddWithValue("@urole", role);
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("User inserted");
                }
                else
                    Console.WriteLine("User registration failed");
            }
            catch (SqlException se)
            {
                Console.WriteLine("Sql is not wokinga s expected");
                Debug.WriteLine(se.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InsertUsingSP();
            program.FetchAndDisplayDataUsingSP();
            Console.WriteLine("Hello, World!");
        }
    }
}