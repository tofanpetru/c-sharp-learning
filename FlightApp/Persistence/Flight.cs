using System;

namespace Persistence
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightDuration { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
    }
}
