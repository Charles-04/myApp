using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public class BreakandContinue
    {

        public static void FourthSolution()
        {
            void CountEvenNumbers()
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 2 == 0)
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
    }
}
