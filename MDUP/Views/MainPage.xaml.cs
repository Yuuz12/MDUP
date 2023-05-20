using Microsoft.UI.Xaml.Controls;

using MDUP.ViewModels;
using Microsoft.UI.Xaml;

namespace MDUP.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
