using PlatziTest.Views.Pages.FlyoutSample;

namespace PlatziTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new FlyoutSamplePage();
	}
}
