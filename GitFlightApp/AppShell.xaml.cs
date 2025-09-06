using GitFlightApp.Pages;

namespace GitFlightApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddNewFlight), typeof(AddNewFlight));
            Routing.RegisterRoute(nameof(FlightConnectionDetails), typeof(FlightConnectionDetails));
            
        }
    }
}
