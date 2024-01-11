using System.Windows.Controls;

using PDF.ViewModels;

namespace PDF.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
