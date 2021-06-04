using System;

namespace FlightApi
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException() : base("Object not found")
        {
        }
    }
}
