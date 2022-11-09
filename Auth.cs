using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public class Auth
    {
        public static void FifthSolution()
        {
            Console.WriteLine("Enter Your name");

            string username = Console.ReadLine();

            Console.WriteLine("Enter Your Password");

            string password = Console.ReadLine();

            List<string> Users = new List<string>();

            Users.Add(username);

            List<string> Password = new List<string>();

            Password.Add(password);
            void Login()
            {
                Console.WriteLine("Log In");
                Console.WriteLine("Enter Your name");
                string username1 = Console.ReadLine();
                Console.WriteLine("Enter Your Password");
                string password1 = Console.ReadLine();

                if (Users.Contains(username1) && Password.Contains(password1))
                {
                    Console.WriteLine("You're Logged in");
                }
                else
                {
                    Console.WriteLine("Wrong Credentials");
                }

            }
            Login();
        }
    }
}
