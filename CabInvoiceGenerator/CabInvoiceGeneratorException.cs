using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    // Custom Exception for Cab Invoice Program
    class CabInvoiceGeneratorException :Exception 
    {
        public ExceptionType type;

        // Enum for defining different type of custom exception
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            INVALID_RIDETYPE,
            NULL_RIDES
        }
        // Initializes a new instance
        public CabInvoiceGeneratorException (ExceptionType type,string message):base(message)
        {
            this.type = type;
        }

    }
}
