using System;
using System.Collections.Generic;

namespace MovieBookingApp
{
    class Program
    {
        public static List<Movie> moviesList = new List<Movie>();
        public static List<Ticket> ticketsList = new List<Ticket>();
        public static void Main(string[] args)
        {
            DefaultValues();
            System.Console.WriteLine("************");
            System.Console.WriteLine("MOVIE TICKET BOOKING APPLICATION");
            System.Console.WriteLine("************");
            System.Console.WriteLine("Dear viewer, Please enter the movie name do you want to watch");
            string movieTitle = "", movieCast = "";
            double ticketPrice = 0;
            foreach (Movie movie in moviesList)
            {
                System.Console.WriteLine($"{movie.Id}. {movie.Title}");
            }
            try
            {
                System.Console.Write("Enter the movie name : ");
                movieTitle = Console.ReadLine().ToLower();
                System.Console.Write("Enter the cast names (Cast names seperated by comma) ");
                movieCast = Console.ReadLine();
                System.Console.Write("Enter the ticket price : ");
                ticketPrice = double.Parse(Console.ReadLine());
                if (movieCast == "")
                {
                    throw new Exception("Movie cast cannot be empty. Please provide valid value");
                }
                if (movieTitle == "")
                {
                    throw new Exception("Movie title cannot be empty. Please provide valid value");
                }
                if (ticketPrice == 0)
                {
                    throw new Exception("Incorrect value for Movie price. Please provide valid value");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                Main(args);
            }
            foreach (Movie movie in moviesList)
            {
                if (movie.Title.Equals(movieTitle))
                {
                    System.Console.WriteLine($"Dear Viewer you have chosen to watch : {movie.Id}");
                    System.Console.WriteLine($"Movie Name : {movie.Title}\nMovie Cast : {movie.Cast}\nTicket Price : {movie.TicketPrice}");
                    System.Console.WriteLine("Do you want to buy ticket for this movie (yes or no)");
                    string choice = Console.ReadLine().ToLower();
                    if (choice.Equals("yes"))
                    {
                        System.Console.WriteLine("Please enter the date on which you want to buy the tickets in dd/mm/yyyy");
                        DateTime bookingDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        System.Console.WriteLine("How many tickets do you want ?");
                        int ticketCount = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Dear viewers your movie details are as follows :");
                        double totalAmount = ticketCount * movie.TicketPrice;
                        Ticket ticket = new Ticket(movie, bookingDate, ticketCount, totalAmount);
                        ticketsList.Add(ticket);
                        System.Console.WriteLine($"Movie name : {movie.Title}\nBooking date : {bookingDate}\nTotal price : {totalAmount}");
                        System.Console.WriteLine("Thank you enjoy your movie, Have a great day!");
                    }
                }
            }

        }

        public static Movie CreateMovie(int id,string title, string cast, double price)
        {
            Movie movie = new Movie(id,title, cast, price);
            return movie;
        }

        public static void DefaultValues()
        {
            Movie movie = new Movie(1,"goodfellas", "Ray Liotta,Robert De Niro", 100);
            Movie movie1 = new Movie(2,"pulp fiction", "John Travolta,Samuel Jackson", 100);
            Movie movie2 = new Movie(3,"maheshinte prathikaram", "Fahad Fazil,Aparna Balamurali", 100);
            moviesList.Add(movie);
            moviesList.Add(movie1);
            moviesList.Add(movie2);
        }
    }

}
    

