using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public  class UppercaseCount
    {
        public static void SecondSolution()
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
                    string Indices = string.Join(',', IndexArray);
                    Console.WriteLine(Indices);
                }
                else
                {
                    Console.WriteLine("Word does not contain an uppercase latter");
                }
            }
            CheckUpperCase();
        }
    }
}
