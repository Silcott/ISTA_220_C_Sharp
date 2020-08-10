#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(weddingAnniversary);
            Console.WriteLine((int)Month.July);
            Console.WriteLine((Month)4);//May and 4 are the same thing
            Console.WriteLine(weddingAnniversary.GetType());
            String johnny = defaultDate.ToString();
            Console.WriteLine(johnny);
            Console.WriteLine("Johnny type is  " + johnny.GetType());

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            Console.WriteLine(weddingAnniversaryCopy.GetType());

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
