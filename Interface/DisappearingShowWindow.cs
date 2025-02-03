using DisappearingWindow.View;
using System.Windows;

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
        try
        {
            Application.Current.Dispatcher.Invoke(() => _mainWindow = App.GetService<MainWindow>());
            _mainWindow.Init(message, size, time);
        }
        catch (Exception ex) { }
    }

    public async Task ShowAsync(string message, int size, int time)
    {
        try
        {
            Application.Current.Dispatcher.Invoke(() => _mainWindow = App.GetService<MainWindow>());
            await _mainWindow.Init(message, size, time);
        }
        catch (Exception ex) { }
    }
}
