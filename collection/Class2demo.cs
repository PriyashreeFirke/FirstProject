using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Movie : IComparable<Movie>
    {
        string moviename;
        int movierating;
        string directorname;
        public int CompareTo(Movie m2)
        {
            //return this.Movierating.CompareTo(m2.Movierating);//ascending order
            return m2.Movierating.CompareTo(this.Movierating);
        }

        public Movie(string moviename, int movierating, string directorname)
        {
            this.Moviename = moviename;
            this.Movierating = movierating;
            this.Directorname = directorname;
        }

        public string Moviename { get => moviename; set => moviename = value; }
        public int Movierating { get => movierating; set => movierating = value; }
        public string Directorname { get => directorname; set => directorname = value; }


        public override string ToString()
        {


            return $"moviename:{moviename} directorName:{directorname} movierating :{Movierating}";
        }
    }

        class Class2demo
        {
            static void Main(string[] args)
            {
                List<Movie> lst = new List<Movie>();
                lst.Add(new Movie("R1", 4, "Rajkumar"));
                lst.Add(new Movie("joker", 5, "sanjay"));
                lst.Add(new Movie("kites", 3, "abc"));
                lst.Add(new Movie("story", 2, "karan"));
                lst.Sort();

                foreach (Movie m in lst)
                {

                    Console.WriteLine(m);
                }
            }
        }
    }

