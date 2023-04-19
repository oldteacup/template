using CommunityToolkit.Mvvm.ComponentModel;

namespace QuickDevelopSolution.App.ViewModel.WindowViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public string Title { get; set; } = nameof(QuickDevelopSolution.App);

        public MainWindowViewModel()
        {

        }
    }
}
