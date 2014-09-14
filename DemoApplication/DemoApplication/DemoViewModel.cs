using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AmadeusW.DemoApplication
{
    class DemoViewModel : BaseViewModel
    {
        public DemoViewModel()
        {

        }

        #region Data bindings

        private String _message = String.Empty;
        public String Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                NotifyPropertyChanged();
            }
        }

        private String _userName;
        public String UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                NotifyPropertyChanged();
            }
        }

        private int _activeStep = 1;
        public int ActiveStep
        {
            get
            {
                return _activeStep;
            }
            set
            {
                _activeStep = value;
                NotifyPropertyChanged();
            }
        }
        


        #endregion

        #region Command handlers



        #endregion

    }
}
