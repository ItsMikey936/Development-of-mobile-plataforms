using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GitFlightApp.Models
{
    //public class FlightViewModel
    //{
    //    public event PropertyChangingEventHandler? PropertyChanged;

    //    private string flightNumber = string.Empty;
    //    private string price = string.Empty;
    //    private DateTime _departureDate = DateTime.Now;

    //    public string FlightNumber 
    //    { 
    //        get => flightNumber; 
    //        set 
    //        {
    //            if (flightNumber != value)
    //            {
    //                flightNumber = value;
    //                OnPropertyChanged(nameof(FlightNumber));
    //            }
    //        }
    //    }

    //    public string Price 
    //    { 
    //        get => price; 
    //        set 
    //        {
    //            if (price != value)
    //            {
    //                price = value;
    //                OnPropertyChanged(nameof(Price));
    //            }
    //        }
    //    }

    //    public DateTime DepartureDate 
    //    { 
    //        get => _departureDate; 
    //        set 
    //        {
    //            if (_departureDate != value)
    //            {
    //                _departureDate = value;
    //                OnPropertyChanged(nameof(DepartureDate));
    //            }
    //        }
    //    }


    //    public ICommand AddNewFlightCommand { get; }

    //    /// <summary>
    //    /// Flight View Model Constructor
    //    /// </summary>
    //    public FlightViewModel()
    //    {
    //        AddNewFlightCommand = new Command(OnAddNewFlight);
    //    }

    //    private async void OnAddNewFlight()
    //    {
    //        if (string.IsNullOrEmpty(FlightNumber) || string.IsNullOrEmpty(Price))
    //        {
    //            await Shell.Current.DisplayAlert("Error", "The flight info is not complete", "Ok");
    //            return;
    //        }

    //        if (GlobalData.Flights.FirstOrDefault(f => f.FlightNumber.Equals(FlightNumber)) != null)
    //        {
    //            await Shell.Current.DisplayAlert("Error", $"Flight Number {FlightNumber} already exist", "Ok");
    //            return;
    //        }

    //        Flight flight = new()
    //        {
    //            FlightNumber = FlightNumber.Trim(),
    //            DepartureDate = DepartureDate,
    //            Price = decimal.Parse(Price)
    //        };

    //        GlobalData.Flights.Add(flight);
    //        await Shell.Current.DisplayAlert("Success", "New Flight Added", "Ok");
    //        await Shell.Current.GoToAsync("..");
    //    }

    //    /// <summary>
    //    /// Method that triggers the PRpoperty Changed event
    //    /// </summary>
    //    /// <param name="propertyName">Property wich its value was changed</param>
    //    protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangingEventArgs(propertyName));
    //}

    public partial class  FlightViewModel : ObservableObject
    {
        [ObservableProperty]
        private string flightNumber = string.Empty;

        [ObservableProperty]
        private string price = string.Empty;

        [ObservableProperty]
        private DateTime _departureDate = DateTime.Now;

        [RelayCommand]
        public async Task AddNewFlight()
        {
            if (string.IsNullOrEmpty(FlightNumber) || string.IsNullOrEmpty(Price))
            {
                await Shell.Current.DisplayAlert("Error", "The flight info is not complete", "Ok");
                return;
            }

            if (GlobalData.Flights.FirstOrDefault(f => f.FlightNumber.Equals(FlightNumber)) != null)
            {
                await Shell.Current.DisplayAlert("Error", $"Flight Number {FlightNumber} already exist", "Ok");
                return;
            }

            Flight flight = new()
            {
                FlightNumber = FlightNumber.Trim(),
                DepartureDate = DepartureDate,
                Price = decimal.Parse(Price)
            };

            GlobalData.Flights.Add(flight);
            await Shell.Current.DisplayAlert("Success", "New Flight Added", "Ok");
            await Shell.Current.GoToAsync("..");
        }
    }
}
