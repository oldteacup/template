using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using DDDTemplateSolution.App.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DDDTemplateSolution.App.ViewModel.Windows
{
    public class MainWindowViewModel : ObservableRecipient, ITransientDependency
    {
        public ILogger<MainWindowViewModel> Logger { get; set; }
        public IHelloWorldService _helloWorldService { get; set; }

        public IRelayCommand GoodByeButtonClickedCommand { get; private set; }

        public MainWindowViewModel(IHelloWorldService helloWorldService)
        {
            Logger = NullLogger<MainWindowViewModel>.Instance;
            _helloWorldService = helloWorldService;
            GoodByeButtonClickedCommand = new RelayCommand(GoodByeButtonClicked);
        }

        private void GoodByeButtonClicked()
        {
            Logger.LogInformation("Say GoodBye Button Clicked !");
            _helloWorldService.SayGoodBye();
            throw new ArgumentException("人为导致异常");
        }
    }
}
