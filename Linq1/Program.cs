using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            //Compilation
            /* IEnumerable<int> query =
                 from num in numbers
                 where (num % 2) == 0
                 select num;*/
            var query =
                from num in numbers
                where (num % 2) == 0
                select num;
            //Execution = exploitation de la requete
            // 3. Query execution.
            foreach (var num in query)
            {
                Console.Write("{0,1} ", num);
            }
            Console.ReadKey();
        }
    }
}
