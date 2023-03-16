using CommunityToolkit.Maui.Views;

namespace TimeKeeper;

public partial class TimeSetterPageDetail : ContentPage
{
	public TimeSetterPageDetail()
	{
		InitializeComponent();
	}

    private async void BtnNewEvent_Clicked(object sender, EventArgs e)
    {
        //this.ShowPopup(new TimeSetterPageDetail());
        await Shell.Current.GoToAsync("TimeSetterPageDetail");

    }

    private void BtnNewTimer_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnNewAutomation_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnNewNotification_Clicked(object sender, EventArgs e)
    {

    }
}