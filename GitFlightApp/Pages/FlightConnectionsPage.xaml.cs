using GitFlightApp.Models;
using System.Threading.Tasks;

namespace GitFlightApp.Pages;

public partial class FlightConnectionsPage : ContentPage
{
	public FlightConnectionsPage()
	{
		InitializeComponent();
	}

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		if (e.CurrentSelection.FirstOrDefault() is not FlightConnection selectedConnection)
			return;

		var navParams = new Dictionary<string, object>()
		{
			{"SelectedConnetion", selectedConnection }
		};

		await Shell.Current.GoToAsync($"/{nameof(FlightConnectionDetails)}", navParams);

		//DownCasting
		((CollectionView)sender).SelectedItem = null;

    }
}