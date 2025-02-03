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

    public void Show(string message, int size, int time)
    {
         _mainWindow.Init(message,size, time);
    }

    public async Task ShowAsync(string message, int size, int time)
    {
        await _mainWindow.Init(message,size, time);
    }
}
