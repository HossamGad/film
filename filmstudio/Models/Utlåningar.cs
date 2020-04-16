using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
	 public static class Utlåningar
	{
        static readonly List<string> _list; // Static List instance

        static Utlåningar()
        {
           
            _list = new List<string>();
        }
        public static void Record(string value)
        {
            //
            // Record this value in the list.
            //
            _list.Add(value);
        }

        public static void Display()
        {
            //
            // Write out the results.
            //
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }
        }

    }
}
