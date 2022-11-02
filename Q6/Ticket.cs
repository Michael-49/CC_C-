using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingApp
{
    public class Ticket
    {
        public Movie Movie { get; set; }
        public DateTime BookingDate { get; set; }
        public int TicketCount { get; set; }
        public double TotalAmount { get; set; }

        public Ticket(Movie movie, DateTime date, int ticketCount, double totalAmount)
        {
            Movie = movie;
            BookingDate = date;
            TicketCount = ticketCount;
            TotalAmount = totalAmount;
        }
    }
}
