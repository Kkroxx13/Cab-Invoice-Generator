using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public int TotalNumberOfRides { get; set; }
        public double TotalFare { get; set; }
        public double AverageFarePerRide { get; set; }
        public void CalculateAverageFare()
        {
            AverageFarePerRide = TotalFare / TotalNumberOfRides;
        }
    }
}
