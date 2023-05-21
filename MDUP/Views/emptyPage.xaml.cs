using MDUP.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace MDUP.Views;

public sealed partial class emptyPage : Page
{
    public emptyViewModel ViewModel
    {
        get;
    }

    public emptyPage()
    {
        ViewModel = App.GetService<emptyViewModel>();
        InitializeComponent();
    }
}
