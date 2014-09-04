using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterHelper.PrinterHelperMethod("Hello Github");
            PrinterHelper.PrinterHelperMethod("Lets add a new line of code here.");
            PrinterHelper.PrinterHelperMethod("We love to party!");

            PrinterHelper.PrinterHelperMethod("Doing some more work here... " + (1 + 2));
            PrinterHelper.PrinterHelperMethod("Looks like we have some math: " + Math.Sqrt(36));

        }
    }
}
