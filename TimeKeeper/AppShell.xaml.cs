using TimeKeeper.Views;

namespace TimeKeeper;

public partial class AppShell : Shell
{
	public AppShell()
	{
		Routing.RegisterRoute(nameof(AddTimePage), typeof(AddTimePage));
        Routing.RegisterRoute(nameof(EditTimePage), typeof(EditTimePage));
        Routing.RegisterRoute(nameof(TimeSetterPage), typeof(TimeSetterPage));

        InitializeComponent();
	}
}
