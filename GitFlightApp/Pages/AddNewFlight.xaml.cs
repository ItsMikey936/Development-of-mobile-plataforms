using GitFlightApp.Models;
using System.Threading.Tasks;

namespace GitFlightApp.Pages;

public partial class AddNewFlight : ContentPage
{
	public AddNewFlight()
	{
		InitializeComponent();
		BindingContext = new FlightViewModel();
    }

  //  private async void OnAddNewFlight(object sender, EventArgs e)
  //  {
		//if(string.IsNullOrEmpty(FlightNumberEntry.Text) || string.IsNullOrEmpty(PriceEntry.Text))
		//{
		//	await DisplayAlert("Error", "The flight info is not complete", "Ok");
		//	return;
		//}

		//if(GlobalData.Flights.FirstOrDefault(f=>f.FlightNumber.Equals(FlightNumberEntry.Text)) != null)
		//{
		//	await DisplayAlert("Error", $"Flight Number {FlightNumberEntry.Text} already exist", "Ok");
		//	return;
		//}

		//Flight flight = new()
		//{
		//	FlightNumber = FlightNumberEntry.Text.Trim(),
		//	DepartureDate = DepartureDateEntry.Date,
		//	Price = decimal.Parse(PriceEntry.Text)
		//};

		//GlobalData.Flights.Add(flight);
		//await DisplayAlert("Success", "New Flight Added", "Ok");
		//await Shell.Current.GoToAsync("..");
  //  }

}