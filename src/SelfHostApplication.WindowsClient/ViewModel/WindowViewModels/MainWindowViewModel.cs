using CommunityToolkit.Mvvm.ComponentModel;

namespace SelfHostApplication.WindowsClient.ViewModel.WindowViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public string Title { get; set; } = nameof(SelfHostApplication.WindowsClient);

        public MainWindowViewModel()
        {

        }
    }
}
