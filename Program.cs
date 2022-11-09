using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace myApp
{
    class Solutions
    {
        static void Main()
        {

            void FirstSolution()
            {
                Console.WriteLine("Enter a word");
                string Text = Console.ReadLine();



                void hashString()
                {
                    if (Text.Length >= 5)
                    {
                        char[] TextToHash  = Text.ToArray();
                        for (int i = 0; i < TextToHash.Length - 4; i++)
                        {
                            TextToHash[i] = '#';
                        }
                        Console.WriteLine(TextToHash);
                    }
                    else if (Text.Length <= 4)
                    {
                        Console.WriteLine(Text);
                    }
                    else
                    {
                        Console.WriteLine("Input right characters ");
                    }
                }
                hashString();
            }
            //FirstSolution();



            void SecondSolution()
            {

                 void CheckUpperCase()
                {
                    Console.WriteLine("enter a word");
                    string word = Console.ReadLine();


                    if (word.Any(c => char.IsUpper(c)))
                    {
                        List<int> IndexArray = new List<int>();
                        foreach (char letter in word)
                        {
                            if (Char.IsUpper(letter))
                            {
                                IndexArray.Add(word.IndexOf(letter));
                            }
                        }
                        string Indices = string.Join(',',IndexArray);
                        Console.WriteLine(Indices);
                    }
                    else
                    {
                        Console.WriteLine("Word does not contain an uppercase latter");
                    }
                }
                CheckUpperCase();
            }
          // SecondSolution();
        
           




            void ThirdSolution()

            {
                Console.WriteLine("Enter a date with the format dd/mm/yyyy");
                var date = Console.ReadLine();
                var parsedDate = DateTime.Parse(date);
                void AddDays()
                {
                   var newDate = parsedDate.AddDays(7);
                    Console.WriteLine(newDate.ToString());
                }
                AddDays();
            }

            //ThirdSolution();



            void FourthSolution()
            {
                void CountEvenNumbers()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        else if (i % 2 == 1)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                CountEvenNumbers();
            }


            void FifthSolution()
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

                    if(Users.Contains(username1) && Password.Contains(password1)){
                        Console.WriteLine("You're Logged in");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Credentials");
                    }

                }
                Login();
            }
           // FifthSolution();


            void SixthSolution()
            {
                Console.WriteLine("Hi, What's your name ? ");
                var name = Console.ReadLine();
                Console.WriteLine("Dear " + name + " Welcome to our Library");
                Console.WriteLine(" We have a couple of books to choose from");
                Console.WriteLine(" Enter 'c' for C# books ");
                Console.WriteLine(" Enter 'o' for Dotnet books ");
                Console.WriteLine(" Enter 'd' for Clean Coding");
                Console.WriteLine(" Enter 'e' for EFCore Books");

                var SelectedOption = Console.ReadLine();
                void CheckOptions()
                {
                    switch (SelectedOption)
                    {
                        case "c":
                            Console.WriteLine(" You Selected C# books");
                            break;
                        case "o":
                            Console.WriteLine(" You selected Dotnet books ");
                            break;
                        case "d":
                            Console.WriteLine(" You selected Clean Coding books ");
                            break;
                        case "e":
                            Console.WriteLine(" You selected EFCore books ");
                            break;
                        default:
                            Console.WriteLine(" You made an invalid selection ! Try again ");
                            Retry();
                            break;
                    }
                }

                CheckOptions();
                void Retry()
                {
                    Console.WriteLine(" Enter '1' to Try again or Enter any other key to exit");
                    var Option = Console.ReadLine();
                    int option;
                    int.TryParse(Option, out option);
                    int RETRYOPTION = 1;
                    if (option == RETRYOPTION)
                    {
                        SixthSolution();
                    }
                    else
                    {
                        return;
                    }
                  
                }
            }
            SixthSolution();
        }
    }
}

    
 
    


    