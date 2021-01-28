using System;

using ClientServerProgWeek1.NetworksWeek1;

namespace ClientServerProgWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = FullName("G.", "Karim");
            Console.WriteLine("The output is {0}", name);

            Program p = new Program();
            string name2 = p.FullName2("G.", "Karim");

            string fname = null;
            var lname = "Karim";
            var name3 = p.getFullNameLength(fname, lname);

            TestPerson();


            
        }

        public static void TestMultiDimArrays()
        {
            int[,] matrix = new int[3, 3];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                    Console.WriteLine("{0}", matrix[i, j]);
                }
                Console.WriteLine
            }

  
        }

        public static void TestPerson()
        {
            var p = new Person()
            { Name = "Bob", Lastname = "Larry", Age = 17, Address = "Sunnyvale" };

            Person[] persons = new Person[3];
            persons[0].Name = "Tom";
            persons[1].Name = "Larry";
            persons[2].Name = "Bob";
           
        }

        public static string FullName(string name, string lastname)
        {
            return name + " " + lastname;
        }

        public string FullName2(string name, string lastname)
        {
            return name + " " + lastname;
        }

        public int getFullNameLength(string name, string lastname)
        {
            if(name == null || lastname == null)
            {
                return -1;
            }

            return name.Length + lastname.Length + 1;
        }

        public struct Point
        {
            public int X;
            public int Y;
        }
    }

 
    public class NameLib
    {
        private string name;
        private string lastname;
        public string CompelteName;

        public static string FullName(string name, string lastName)
        {
            return name + " " + lastName;
        }
    }
}
