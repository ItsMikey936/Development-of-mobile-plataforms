using GitFlightApp.Models;

namespace GitFlightApp.Pages;

public partial class AddNewConnection : ContentPage
{
	public AddNewConnection()
	{
		InitializeComponent();
        BindingContext = new ConnectionViewModel();
    }
}