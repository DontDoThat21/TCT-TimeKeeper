using CommunityToolkit.Maui.Views;

namespace TimeKeeper.Views;

public partial class TimeSetterPageDetail : ContentPage
{
	public TimeSetterPageDetail()
	{
		InitializeComponent();
	}

    private async void BtnNewEvent_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TimeEventSetterPage");
    }

    private async void BtnNewTimer_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TimeTimerPage");
    }

    private void BtnNewAutomation_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnNewNotification_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TimeNotificationPage");
    }
}