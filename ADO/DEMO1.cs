using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject.ADO
{
    class Demo1
    {
        const string connectionstring = "server=MITHILAPTOP\\SQLEXPRESS;Database=Librarymanagement;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                return con;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

    }
    class DB
    {
        static void Main(string[] args)
        {
            SqlConnection c = Demo1.GetConnection();
            c.Open();
            while(true)
            {
                SqlCommand cmd = new SqlCommand("insert into book values(@id,@bkname,@anme,@price,@no)", c);
                Console.WriteLine("enter bookid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter authorname");
                string aname = Console.ReadLine();
                Console.WriteLine("enter price");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("enter noofcopies");
                int n = int.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bkname", bookname);
                cmd.Parameters.AddWithValue("@anme", aname);
                cmd.Parameters.AddWithValue("@price", pr);
                cmd.Parameters.AddWithValue("@no", n);
                int count = cmd.ExecuteNonQuery();
                Console.WriteLine(count);
                if(count >0)
                    Console.WriteLine("sucessfully inserted");

                Console.WriteLine("do you want to add one more yes/no");
                string choice = Console.ReadLine();

                if (choice == "no")
                    break;


            }

        }
    }
}


