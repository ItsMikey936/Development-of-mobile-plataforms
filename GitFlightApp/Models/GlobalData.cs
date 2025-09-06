using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
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
                new()
                {
                FlightNumber = "LH456",
                Price = 7600,
                DepartureDate = new DateTime(2025,9,1),

                },

                new()
                {
                FlightNumber = "AH453",
                Price = 300,
                DepartureDate = new DateTime(2025,10,10),

                }
            ];

        private static ObservableCollection<FlightConnection> flightConnections = [
            new()
                {
                    Airline = "Iberia",
                    DepartureCity = "Chicago",
                    ConnectionID = "A14",
                    ArrivalCity = "New York",
                    Flights = [flights.FirstOrDefault()]
                }

            ];

        public static ObservableCollection<Flight> Flights { get => flights; set => flights = value; }
        public static ObservableCollection<FlightConnection> FlightConnections { get => flightConnections; set => flightConnections = value; }


    }
}
