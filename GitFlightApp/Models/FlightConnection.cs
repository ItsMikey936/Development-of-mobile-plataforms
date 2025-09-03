﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace GitFlightApp.Models
{
    public class FlightConnection
    {
        public string ConnectionID { get; set; } = string.Empty;

        public string Airline { get; set; } = string.Empty;

        public string DepartureCity { get; set; } = string.Empty;

        public string ArrivalCity { get; set; } = string.Empty;

        public ObservableCollection<Flight> Flights { get; set; }
    }
}