namespace TimeKeeper.Views;

public partial class TimeSetterPage : ContentPage
{
	public TimeSetterPage()
	{
		InitializeComponent();
	}

	private async void AlertDBOfClick_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("MainPage");
    }
}