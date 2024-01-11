using System.Windows.Controls;

using PDF.ViewModels;

namespace PDF.Views;

public partial class BlankPage : Page
{
    public BlankPage(BlankViewModel viewModel)
    {
        //InitializeComponent();
        DataContext = viewModel;
    }
}
