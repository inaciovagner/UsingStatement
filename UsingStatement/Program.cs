using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatement
{
    class check_using : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Execute Second");
        }
        static void Main(string[] args)
        {
            using (check_using c = new check_using())
            {
                Console.WriteLine("Execute First");
            }
            Console.WriteLine("Execute Third");
            Console.ReadLine();
        }
    }
}
