using Uno.UI.Hosting;

namespace WinUI.TableView.SampleApp;

public class Program
{
    private static App? _app;

    static async Task Main(string[] args)
    {
        var host = UnoPlatformHostBuilder.Create()
				.App(() => new App())
				.UseWebAssembly()
				.Build();

		await host.RunAsync();
    }
}
