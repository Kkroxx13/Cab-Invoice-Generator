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
            //Arrange
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(10.0, 2), new Ride(10.0, 2), new Ride(10.0, 2) };
            //Act
            double fare = invoice.CalculateFare(rides);
            double expected = 306;
            //Assert
            Assert.AreEqual(expected, fare);
                
        }
    }
}