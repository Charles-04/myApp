using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public class Hashname
    {
        public static void FirstSolution()
        {
            Console.WriteLine("Enter a word");
            string Text = Console.ReadLine();



            void hashString()
            {
                if (Text.Length >= 5)
                {
                    char[] TextToHash = Text.ToArray();
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
    }
}
