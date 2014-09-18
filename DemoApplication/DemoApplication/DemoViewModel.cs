using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AmadeusW.DemoApplication
{
    internal class DemoViewModel : BaseViewModel
    {
        DummyDataProvider provider;

        public DemoViewModel()
        {
            provider = new DummyDataProvider();
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

        private MessageStatus _messageStatus = MessageStatus.Closed;
        public MessageStatus Status
        {
            get
            {
                return _messageStatus;
            }
            set
            {
                _messageStatus = value;
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

        private ApplicationSteps _activeStep = ApplicationSteps.LogIn;
        public ApplicationSteps ActiveStep
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

        private ObservableCollection<DemoObject> _demoItems1;
        public ObservableCollection<DemoObject> demoItems1
        {
            get
            {
                return _demoItems1;
            }
            set
            {
                _demoItems1 = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<DemoObject> _demoItems2;
        public ObservableCollection<DemoObject> demoItems2
        {
            get
            {
                return _demoItems2;
            }
            set
            {
                _demoItems2 = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command handlers

        internal void LogIn(string password)
        {
            Message = "Logging in...";

            String connectionStringTemplate = "Data Source = 127.0.0.1; Initial Catalog = DemoCatalog; Persist Security Info = True; User ID={0};Password={1}";
            String connectionString = String.Format(connectionStringTemplate, UserName, password);

            // TODO: async
            try
            {
                provider.LogIn(connectionString);
            }
            catch (Exception ex)
            {
                Message = "Could not log in: " + ex.Message;
                Status = MessageStatus.ErrorMessage;
                return;
            }

            // Notify the user
            Message = "Successfully logged in!";
            Status = MessageStatus.InfoMessage;

            // Show the next screen
            ActiveStep = ApplicationSteps.ChooseView;
        }

        internal void SeeDemoData1()
        {
            ActiveStep = ApplicationSteps.DemoData1;
            demoItems1 = provider.CreateDemoData(50);
        }

        internal void SeeDemoData2()
        {
            ActiveStep = ApplicationSteps.DemoData2;
            demoItems2 = provider.CreateDemoData(50);
        }

        internal void GoBackToChoiceScreen()
        {
            ActiveStep = ApplicationSteps.ChooseView;
        }

        #endregion

    }
}
