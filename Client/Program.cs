using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWcfService.CalculatorServiceClient client = new MyWcfService.CalculatorServiceClient();
            Console.WriteLine("x+y={2} when  x={0} and y={1}", 1, 2, client.Add(1, 2));
            Console.WriteLine("x-y={2} when  x={0} and y={1}", 1, 2, client.Add(1, 2));
            Console.WriteLine("x*y={2} when  x={0} and y={1}", 1, 2, client.Add(1, 2));
            Console.WriteLine("x/y={2} when  x={0} and y={1}", 1, 2, client.Add(1, 2));
            Console.ReadLine();
        }
    }
}
