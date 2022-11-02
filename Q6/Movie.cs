using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBookingApp
{
    public class Movie
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Cast { get; set; }
        public double TicketPrice { get; set; }
        public Movie( int id,string title, string cast, double price)
        {
            Id = id;
            Title = title;
            Cast = cast;
            TicketPrice = price;
        }
    }
}
