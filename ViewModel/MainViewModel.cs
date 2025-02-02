using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace DisappearingWindow.ViewModel;

[ObservableObject]
internal partial class MainViewModel
{
    [ObservableProperty]
    private string _message;

    [ObservableProperty]
    private string _title = "Исчезающее окно";
}
