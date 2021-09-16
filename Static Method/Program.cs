using System;

namespace Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            description();
        }



        public static void description()
        {

            string username = "carl";
            string role = "admin";           

                Console.WriteLine($"User name is: {username} \nUser role is: {role}");          

        }
    }






    }
