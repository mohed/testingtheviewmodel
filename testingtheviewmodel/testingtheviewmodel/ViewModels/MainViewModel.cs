using testingtheviewmodel.Services.Print;
using testingtheviewmodel.ViewModels.Base;
using Xamarin.Forms;

namespace testingtheviewmodel.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IPrintService _printService;
        
        public MainViewModel(IPrintService printService)
        {
            _printService = printService;
        }
        
        public Command PrintCommand => new Command(Print);
        
        private void Print()
        {
            _printService.Print();
        }
    }
}