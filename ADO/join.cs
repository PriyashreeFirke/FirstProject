using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject.ADO
{
    class join
    {
        static void Main(string[] args)
        {


            string str = "server=MITHILAPTOP\\SQLEXPRESS;Database=Hr;Integrated Security=True";
            SqlConnection c = new SqlConnection(str);
            c.Open();
            SqlCommand cm2 = new SqlCommand("select max(salary) from employees", c);
            object ob = cm2.ExecuteScalar();
            Console.WriteLine("max salary"+ob);
            SqlCommand cmd = new SqlCommand("select first_name,salary,department_name from employees e inner join departments d on e.department_id=d.employees_id",c);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader["first_name"]+ " "+reader["salary"]+ " "+reader["department_name"]);
            }
            c.Close();
        }
    }
}
