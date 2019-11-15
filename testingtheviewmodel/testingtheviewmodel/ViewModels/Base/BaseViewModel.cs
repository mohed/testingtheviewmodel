using System.ComponentModel;
using Xamarin.Forms;

namespace testingtheviewmodel.ViewModels.Base
{
    public class BaseViewModel : BindableObject
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }
    }
}