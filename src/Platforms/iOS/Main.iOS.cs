using Uno.UI.Hosting;
using UIKit;

namespace WinUI.TableView.SampleApp.iOS;

public class EntryPoint
{
    // This is the main entry point of the application.
    public static void Main(string[] args)
    {
		var host = UnoPlatformHostBuilder.Create()
			.App(() => new App())
			.UseAppleUIKit()
			.Build();

		host.Run();
    }
}
