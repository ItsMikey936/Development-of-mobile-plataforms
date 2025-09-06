using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFlightApp.Models
{
    //internal class ConnectionViewModel
    //{
    //}

    public partial class ConnectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private string Airline = string.Empty;

        [ObservableProperty]
        private string DepartureCity = string.Empty;

        [ObservableProperty]
        private string ConnectionID = string.Empty;

        [ObservableProperty]
        private string ArrivalCity = string.Empty;

        [RelayCommand]
        public async Task AddNewFlight()
        {
            if (string.IsNullOrEmpty(ConnectionID) || string.IsNullOrEmpty(Airline)) 
            {
                await Shell.Current.DisplayAlert("Error", "The connection info is not complete", "Ok");
                return;
            }

            if (GlobalData.Flights.FirstOrDefault(f => f.FlightNumber.Equals(ConnectionID)) != null)
            {
                await Shell.Current.DisplayAlert("Error", $"Connection: {ConnectionID} already exist", "Ok");
                return;
            }

            Flight flight = new()
            {
                ConnectionID = ConnectionID,
                Airline = Airline,
                Price = decimal.Parse(Price)
            };

            GlobalData.Flights.Add(flight);
            await Shell.Current.DisplayAlert("Success", "New Flight Added", "Ok");
            await Shell.Current.GoToAsync("..");
        }
    }
}
