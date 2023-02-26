namespace TimeKeeper.Views;

public partial class TimeSetterPage : ContentPage
{
	public TimeSetterPage()
	{
		InitializeComponent();
	}

	private async void AlertDBOfClick_Clicked(object sender, EventArgs e)
    {
		MainPage mp = new MainPage();
		await Shell.Current.Navigation.PushModalAsync(mp);
    }
}