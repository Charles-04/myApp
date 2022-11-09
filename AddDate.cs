using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    public class AddDate
    {
        public static void ThirdSolution()

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

    }
}
