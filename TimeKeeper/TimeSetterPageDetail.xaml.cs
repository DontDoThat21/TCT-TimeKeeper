using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;

namespace TimeKeeper;

public partial class TimeSetterPageDetail : ContentPage
{

    List<Task> toastDelays = new List<Task>();

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

        Toast toast = new Toast()
        {
            Text = "Boo!",
            TextSize = 16,            
            Duration = CommunityToolkit.Maui.Core.ToastDuration.Long
        };
        if (toastDelays.Count >= 1)
        {
        }
        else
        {
            Timer_Wip();
        }
    }

    private void Timer_Wip()
    {
        var timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (s, e) => DoSomething();
        timer.Start();
    }
    private void DoSomething()
    {

    }
}