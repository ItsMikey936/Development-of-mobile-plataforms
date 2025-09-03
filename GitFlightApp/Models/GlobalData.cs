using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlightApp.Models
{
    public class GlobalData
    {
        private static ObservableCollection<Flight> flights = [
            new Flight()
            {
                FlightNumber = "LH123",
                Price = 900,
                DepartureDate = DateTime.Now,
            },
            new ()
            {
                FlightNumber = "LH456",
                Price = 1200,
                DepartureDate = new DateTime(2024, 12, 24),
            },
            new ()
            {
                FlightNumber = "AB936",
                Price = 300,
                DepartureDate = new DateTime(2025, 10, 15),
            }

        ];

        private static ObservableCollection<FlightConnection> flightConnections = [
            new ()
            {
                Airline = "Iberia",
                DepartureCity = "Chicago",
                ConnectionID = "A14",
                ArrivalCity = "New York",
                Flights = []
            }
        ];



        public static ObservableCollection<Flight> Flights { get => flights; set => flights = value; }
        public static ObservableCollection<FlightConnection> FlightConnections { get => flightConnections; set => flightConnections = value; }
    }
}
