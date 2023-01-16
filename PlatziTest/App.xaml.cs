using PlatziTest.Views.Pages.FlyoutSample;
using PlatziTest.Views.Pages.TabbedPageSample;

namespace PlatziTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TabbedPageSample();
	}
}
