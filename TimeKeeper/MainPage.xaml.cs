using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls.Xaml;
using TimeKeeper.Views;

namespace TimeKeeper;

public partial class MainPage : ContentPage
{
	int count = 1;
	public Task<TimeSetterPage> PopModalAsync { get; set; }
    public Button btnDaySelected;

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
    // I would like to use the XAML directives, however it's being a PITA so for now I submit to an enum
    List<Color> colors = new List<Color>
    {
        Colors.Red, // red
        Colors.Green, // green
        Colors.Blue, // blue
        Colors.DarkSlateGray // darkslategray
    };

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void BtnTime_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("TimeSetterPage");
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
        btnDaySelected.BackgroundColor = colors.Find(i => i.Equals(Colors.DarkSlateGray)); // should be pulling from xaml dynamically with themes. all in time. // MainPage.Colors.DarkSlateGray;
        Button clicked = (Button)sender;
        clicked.BackgroundColor = colors.Find(i => i.Equals(Colors.Red)); // read above comment

        //await Shell.Current.GoToAsync("TimeSetterPage");
        this.ShowPopup(new TimeSetterPage());
        //await SendDayBlockToDB(sender, e, res);
    }

    private async void BtnTimeSlot_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TimeSetterSlotPage");        
    }

    private async void DayOfWeek_HorizontalStackLoad(object sender, EventArgs e)
    {
        DayOfWeek day = DateTime.Now.DayOfWeek;
        Color selected = colors.Find(i => i.Equals(Colors.Red)); // should be pulling from xaml dynamically with themes. all in time. // MainPage.Colors.DarkSlateGray;

        // this should acco
        double btnWidth = 100; //btnMon.Width;

        switch (day)
        {
            case DayOfWeek.Monday:
                btnWidth *= 0;
                btnMon.BackgroundColor = selected; btnDaySelected = btnMon; break;
            case DayOfWeek.Tuesday:
                btnWidth *= 0;
                btnTue.BackgroundColor = selected; btnDaySelected = btnTue; break;
            case DayOfWeek.Wednesday:
                btnWidth *= 1;
                btnWed.BackgroundColor = selected; btnDaySelected = btnWed; break;
            case DayOfWeek.Thursday:
                btnWidth *= 2;
                btnThu.BackgroundColor = selected; btnDaySelected = btnThu; break;
            case DayOfWeek.Friday:
                btnWidth *= 3;
                btnFri.BackgroundColor = selected; btnDaySelected = btnFri; break;
            case DayOfWeek.Saturday:
                btnWidth *= 3;
                btnSat.BackgroundColor = selected; btnDaySelected = btnSat; break;
            case DayOfWeek.Sunday:
                btnWidth *= 3;
                btnSun.BackgroundColor = selected; btnDaySelected = btnSun; break;
            default:
                break;
        }
        
        await SV_DaysOfWeek.ScrollToAsync(btnWidth, 0, true);

    }

    private void SV_DaysOfWeek_Scrolled(object sender, ScrolledEventArgs e)
    {

    }

}

