using SharedMauiXamlStylesLibrary.SampleApp.ViewModels;

namespace SharedMauiXamlStylesLibrary.SampleApp.Views;

public partial class LabelsPage : ContentPage
{
    public LabelsPage(LabesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}