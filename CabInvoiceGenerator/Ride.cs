using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    //Ride class to set data for particular ride. 
    public class Ride
    {
        //Variable
        public double distance;
        public int time;

        // Initializes a new instance
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
