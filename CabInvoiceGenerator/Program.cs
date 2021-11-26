using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create instance of InvoiceGenerator Class

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double fare=invoiceGenerator.CalculateFare(2.0,0);
            Console.WriteLine("Total Fare is = " + fare);
        }
    }
}
