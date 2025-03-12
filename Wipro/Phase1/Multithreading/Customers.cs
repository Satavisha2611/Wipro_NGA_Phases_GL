using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class Customers
    {
        static async Task ProcessCustomers(string Name, int timeToPrepare)
        {
            Console.WriteLine($"{Name} placed an order");
            await Task.Delay(timeToPrepare * 1000);
            Console.WriteLine($"{Name} order finished {timeToPrepare}");
        }

        static async Task Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Task task1 = ProcessCustomers("sat", 4);
            Task task2 = ProcessCustomers("sata", 5);
            Task task3 = ProcessCustomers("satav", 7);

            await Task.WhenAll(task1, task2, task3);
            sw.Stop();

            Console.WriteLine(sw.Elapsed.Seconds);
        }
    }
}
