using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject.ADO
{
    class DEMO
    {
        static void Main(string[] args)
        {
            string str = "server=MITHILAPTOP\\SQLEXPRESS;Database=Hr;Integrated Security=True";
            // servername//databasename//and windowauthentication use is there so write integrated security=true
            SqlConnection c = new SqlConnection(str);
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from employees",c);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine("name:"+reader["first_name"]+"salary:" + reader["salary"]);
            }
        }
    }
}
