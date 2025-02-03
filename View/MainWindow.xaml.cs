using DisappearingWindow.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Wpf.Ui.Controls;

namespace DisappearingWindow.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private MainViewModel ViewModel;
        public MainWindow(IServiceProvider provider)
        {
            ViewModel = provider.GetRequiredService<MainViewModel>();
            DataContext = ViewModel;
            InitializeComponent();
        }

        public async Task Init(string message, int size, int time)
        {
            try
            {
                await Application.Current.Dispatcher.BeginInvoke(new Action(async () =>
                {
                    ViewModel.Message = message;
                    ViewModel.Size = size;
                    Show();
                    await Task.Delay(time);
                    Close();
                }));
                return;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
