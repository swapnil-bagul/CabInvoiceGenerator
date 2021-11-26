using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            double expected = 25;
            double distance = 2.0;
            int time = 5;

            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoice.CalculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void GivenMultipleRidesReturnTotalFare()
        {


            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary expected = new InvoiceSummary(rides.Length, 60);

            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            Assert.AreEqual(actual, expected);


        }
    }
}
