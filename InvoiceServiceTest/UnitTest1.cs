using NUnit.Framework;
using CabInvoiceGenerator;
namespace InvoiceServiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 10.0;
            int time = 5;

            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 105;

            //Assert
            Assert.AreEqual(expected, fare);

        }
        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.2;
            int time = 1;
            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 5;
            //Assert
            Assert.AreEqual(expected, fare);

        }
        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            Ride[] rides = { new Ride(2.0, 5),
                new Ride(0.1, 1)
            };
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            double expected = 30;
            Assert.AreEqual(expected, invoiceSummary.TotalFare);

        }
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            Ride[] rides = { new Ride(2.0, 5),
                new Ride(0.1, 1)
            };
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 30,
                AverageFarePerRide = 15
            };
            object.Equals(expected, invoiceSummary);
        }
    }
}