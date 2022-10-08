using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FirstProject.ADO
{

    class DEMO1
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
    class DemoMenu
    {
        static void ViewAllBooks()
        {

            SqlConnection c = null;

            try
            {
                c = DEMO1.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("select * from book", c);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("***************View All Books*******************");
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }


        static void AddBook()
        {
            SqlConnection c = null;

            try
            {
                Console.WriteLine("********************Add New Book**********************");
                c = DEMO1.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("insert into book values(@i,@bknm,@anm,@price,@no)", c);
                Console.WriteLine("Enter bookid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter authorname");
                string aname = Console.ReadLine();
                Console.WriteLine("Enter price");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter noOfCopies");
                int n = int.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@i", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);
                cmd.Parameters.AddWithValue("@no", n);
                int count = cmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }



        }

        static void deleteBook()
        {

            Console.WriteLine("Enter bookid u want to delete");
            int bid = int.Parse(Console.ReadLine());
            SqlConnection c = null;
            try
            {
                Console.WriteLine("********************Add New Book**********************");
                c = Demo1.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("delete from book where bookid=@id", c);
                cmd.Parameters.AddWithValue("@id", bid);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Deleted successfully: " + count);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }



        }


        static void updateBook()
        {
            SqlConnection c = null;

            try
            {
                Console.WriteLine("********************Edit Book**********************");
                c = Demo1.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("update book set bookname=@bknm,authorname=@anm,price=@price where bookid=@i", c);
                Console.WriteLine("Enter bookid you want update");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter new bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter new authorname");
                string aname = Console.ReadLine();
                Console.WriteLine("Enter new price");
                int pr = int.Parse(Console.ReadLine());


                cmd.Parameters.AddWithValue("@i", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);

                int count = cmd.ExecuteNonQuery();

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("1---View all books");
                Console.WriteLine("2---Add book");
                Console.WriteLine("3---Delete a Book");
                Console.WriteLine("4---Update a book");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewAllBooks();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        deleteBook();
                        break;
                    case 4:
                        updateBook();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("Do you want continue  yes/no");
                string ch = Console.ReadLine();

                if (ch == "no")
                    break;
            } while (true);
        }






    }
}
    
