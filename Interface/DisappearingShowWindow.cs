using DisappearingWindow.View;
using Microsoft.Extensions.DependencyInjection;

namespace DisappearingWindow.Interface;

public class DisappearingShowWindow
{
    private MainWindow _mainWindow;
    public DisappearingShowWindow()
    {
        _mainWindow = App.GetService<MainWindow>();
    }

    public void Show(string message, int time)
    {
         _mainWindow.Init(message, time);
    }

    public async Task ShowAsync(string message, int time)
    {
        await _mainWindow.Init(message, time);
    }
}
