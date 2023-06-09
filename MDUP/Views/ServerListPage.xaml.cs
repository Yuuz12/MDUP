﻿using MDUP.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace MDUP.Views;

public sealed partial class ServerListPage : Page
{
    public ServerListViewModel ViewModel
    {
        get;
    }

    public ServerListPage()
    {
        ViewModel = App.GetService<ServerListViewModel>();
        InitializeComponent();
    }
}
