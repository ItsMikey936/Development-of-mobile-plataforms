using GitFlightApp.Models;

namespace GitFlightApp.Pages;

[QueryProperty("selectedConnection", "selectedConnection")]

public partial class FlightConnectionDetails : ContentPage
{
	private FlightConnection _selectedConnection;

	public FlightConnection SelectedConnection
	{
		get => _selectedConnection; 
		set 
		{
			_selectedConnection = value;

			if (_selectedConnection != null) 
			{
				connectionsCollectionView.ItemsSource = _selectedConnection.Flights;
			}

		}

	}
	public FlightConnectionDetails()
	{
		InitializeComponent();
	}

}