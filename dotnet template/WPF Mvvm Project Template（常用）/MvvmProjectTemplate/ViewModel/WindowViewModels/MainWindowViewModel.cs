using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmProjectTemplate.ViewModel.WindowViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public string Title { get; set; } = nameof(MvvmProjectTemplate);

        public MainWindowViewModel()
        {

        }
    }
}
