using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange6
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 9, var2 = 11;
            Boolean result, result2;
            result = var1 < 10 && var2 <= 11;
            result2 = var1 < 10 || var2 <= 11;


            Console.WriteLine("{0} \n{1}", result,result2);
            


            Console.ReadKey();
        }
    }
}
