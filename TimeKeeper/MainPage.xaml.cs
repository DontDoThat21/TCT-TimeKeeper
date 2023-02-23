namespace TimeKeeper;

public partial class MainPage : ContentPage
{
	int count = 1;
	public Task<Views.TimeSetterPage> PopModalAsync { get; set; }

    enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void BtnTime_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("TimeSetterPage");	// thanks nick gurfr
		//await DisplayAlert("Sup", "Fire", "Click me");
    }

    private async void SendRequestToDB_Clicked(object sender, EventArgs e)
    {
		await CallNewDBInsert();
    }

    public async Task CallNewDBInsert()
    {
		try
		{
            HttpClient cli = new HttpClient();
            cli.Send(new HttpRequestMessage(HttpMethod.Post, "localhost.com/StressBtn_LeftClicked"));
            cli.Dispose();
        }
		catch (Exception Ex)
		{
			await DisplayAlert(Ex.Message, "MainPage", "HAHA LOLU", "Connection error.");
		}
		await DisplayAlert("DB Called.", "Sent alert to DB, congrats you just upped the world!", "Test");
    }

    private async void BtnMonday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Monday);
    }

    private async void BtnTuesday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Tuesday);
    }

    private async void BtnWednesday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Wednesday);
    }

    private async void BtnThursday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Thursday);
    }

    private async void BtnFriday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Friday);
    }

    private async void BtnSaturday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Saturday);
    }

    private async void BtnSunday_Clicked(object sender, EventArgs e)
    {
        await SetDayRequest_Handler(sender, e, Days.Sunday);
    }

    private async Task SetDayRequest_Handler(object sender, EventArgs e, ValueType res)
    {
        await SendDayBlockToDB(sender, e, res);
    }

    private async Task SendDayBlockToDB(object sender, EventArgs e, ValueType res)
    {
        string gkapimcypabndianfString = "yarr";

        try
        {
            HttpClient cli = new HttpClient();
            cli.Send(new HttpRequestMessage(HttpMethod.Post, $"localhost.com/SendDayBlockToDB?{gkapimcypabndianfString}"));
            cli.Dispose();
        }
        catch (Exception Ex)
        {
            await DisplayAlert(Ex.Message, "MainPage", "HAHA LOLU", "Connection error.");
        }
    }

}

