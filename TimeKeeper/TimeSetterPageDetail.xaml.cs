using CommunityToolkit.Maui.Views;

namespace TimeKeeper;

public partial class TimeSetterPageDetail : Popup
{
	public TimeSetterPageDetail()
	{
		InitializeComponent();
	}

    private void BtnNewEvent_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new TimeSetterPageDetail());
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