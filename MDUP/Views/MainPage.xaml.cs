using Microsoft.UI.Xaml.Controls;

using MDUP.ViewModels;
using Microsoft.UI.Xaml;
using MDUP.Core.Models;
using MDUP.Core.Services;
using MDUP.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.WinUI.UI.Animations;

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
