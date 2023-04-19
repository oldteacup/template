using DDDTemplateSolution.App.IService;
using DDDTemplateSolution.App.ViewModel.Windows;
using System;
using System.Windows;

namespace DDDTemplateSolution.App.View.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IHelloWorldService _helloWorldService;

    public MainWindow(IHelloWorldService helloWorldService, MainWindowViewModel mainWindowViewModel)
    {
        _helloWorldService = helloWorldService;
        DataContext = mainWindowViewModel;
        InitializeComponent();
    }

    protected override void OnContentRendered(EventArgs e)
    {
        HelloLabel.Content = _helloWorldService.SayHello();
    }
}
