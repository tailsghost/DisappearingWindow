using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace DisappearingWindow.ViewModel;

[ObservableObject]
internal partial class MainViewModel
{
    [ObservableProperty]
    private string _message;

    [ObservableProperty]
    private int _size = 16;
}
