using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    class InvoiceGenerator
    {
        //Variables
        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_MINUTE;
        private readonly double MINIMUM_FARE;

        public InvoiceGenerator ()
        {
            this.MINIMUM_COST_PER_KM = 10;
            this.COST_PER_MINUTE = 1;
            this.MINIMUM_FARE = 5;
        }
        //Create Method to Calculate Fare
        public double CalculateFare(double distance,int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_MINUTE;
            }
            catch(CabInvoiceGeneratorException ex)
            {
                if(distance >= 0)
                {
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, "Mention Proper Distance");
                }
                if(time >= 0)
                {
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_TIME, "Mention Proper Time");

                }
                
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
    }
}
