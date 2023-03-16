using CommunityToolkit.Maui.Views;

namespace TimeKeeper.Views;

public partial class TimeSetterPage : ContentPage
{
	public TimeSetterPage()
	{
		InitializeComponent();
	}

	private async void Btn_AlertDBOfClickClicked(object sender, EventArgs e)
    {
		MainPage mp = new MainPage();
		await Shell.Current.Navigation.PushModalAsync(mp);
    }

    private void Btn_WClicked(object sender, EventArgs e)
    {

    }

    private void Btn_EveryDayEntryClicked(object sender, EventArgs e)
    {

    }

    private void Lbl_DayOfWeekGreeterLoad(object sender, EventArgs e)
    {
        Lbl_DayOfWeekGreeter.Text = Lbl_DayOfWeekGreeter.Text.Replace("{day}", DateTime.Now.DayOfWeek.ToString());
    }
}