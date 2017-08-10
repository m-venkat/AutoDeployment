using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using cw = System.Console;

namespace LiquibaseConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            cw.WriteLine("_______________________________________________________________");
            cw.WriteLine("                       LIQUIBASE UPGRADE                       ");
            cw.WriteLine("_______________________________________________________________");
            cw.WriteLine("Environments:");
            cw.WriteLine("\t1-DEV");
            cw.WriteLine("\tL1: LX1");
            cw.WriteLine("\tL2: LX2");
            cw.WriteLine("\tL3: LX3");
            cw.WriteLine("\tL4: LX4");
            cw.WriteLine("\tL9: LX9");
            cw.WriteLine("\tL8: LX8");
            cw.WriteLine("Select your Environment: ");
            string selectedEnvironment  = cw.ReadLine();
            cw.WriteLine($"Thanks for selecting Environment :{selectedEnvironment}");
            cw.WriteLine($"Updating Database .....");
            for (int i = 0; i <= 10; i++) { 
                Thread.Sleep(1000);
                Console.Write(".");
            }
            cw.WriteLine($"Liquibase Successfully Updated....");
            cw.ReadKey();
        }
    }
}
