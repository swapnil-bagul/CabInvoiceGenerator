using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType rideType;

        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;

        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            try
            {
                if (this.rideType.Equals(RideType.NORMAL))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }
                if (this.rideType.Equals(RideType.PREMIUM))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
            }
            catch (CabInvoiceGeneratorException)
            {
                throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_RIDETYPE, "invalid ride type");
            }

        }

        public double calculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance + MINIMUM_COST_PER_KM + time * COST_PER_TIME;


            }
            catch (CabInvoiceGeneratorException)
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, "invalid distance");

                }
                if (distance <= 0)
                {
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.INVALID_TIME, "invalid time");

                }
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }

        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (Ride ride in rides)
                {
                    totalFare += this.calculateFare(ride.distance, ride.time);
                }
            }
            catch (CabInvoiceGeneratorException)
            {
                if (rides == null)
                {
                    throw new CabInvoiceGeneratorException(CabInvoiceGeneratorException.ExceptionType.NULL_RIDES, "no rides found");

                }
            }
            return new InvoiceSummary(rides.Length, totalFare);
        }

    }
}
