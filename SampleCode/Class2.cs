using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
            int sub = a - b;
            Console.WriteLine(sub);
            int m = a * b;
            Console.WriteLine(m);
            int div = a / b;
            Console.WriteLine(div);
            int mod = a % b;
            Console.WriteLine(mod);
        
        }
    }
}
