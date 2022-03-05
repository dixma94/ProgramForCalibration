using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NationalInstruments.Visa;
using System.Windows.Input;

namespace ProgramForCalibration.ViewModel
{
     public class OpenSessionDialog_VM:BaseViewModel
    {
        Model.GpibSession gpibSession;
        public OpenSessionDialog_VM()
        {
            
        }
        public OpenSessionDialog_VM(Model.GpibSession session)
        {
            gpibSession = session;
            OnPropertyChanged("AvailableResoursesList");
            ResourceName = AvailableResoursesList.FirstOrDefault();
        }

        private ObservableCollection<string> _AvailableResoursesList = new ObservableCollection<string>();
        public ObservableCollection<string> AvailableResoursesList
        {
            get {
                var rm = new ResourceManager();
                var resources = rm.Find("GPIB?*");
                _AvailableResoursesList.Clear();
                foreach (string s in resources)
                {
                    _AvailableResoursesList.Add(s);
                }

                return _AvailableResoursesList;
            }
            set { _AvailableResoursesList = value;
                OnPropertyChanged();
            }
        }


        private string _ResourceName ;

        public string ResourceName
        {
            get { return _ResourceName; }
            set { _ResourceName = value;
                OnPropertyChanged();
            }
        }

        public void ConnectToDevice()
        {
            gpibSession.Connect(ResourceName);
        }
        public static ExecutedRoutedEventHandler Refresh
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {

                    var vm = e.Parameter as OpenSessionDialog_VM;
                    vm.OnPropertyChanged("AvailableResoursesList");

                };
            }
        }
        public static ExecutedRoutedEventHandler Cancel
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {

                    var window = sender as View.OpenSessionDialog_View;
                    window.Close();
                };
            }
        }
        public static ExecutedRoutedEventHandler OK
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {
                    var vm = e.Parameter as OpenSessionDialog_VM;
                    vm.ConnectToDevice();
                    var window = sender as View.OpenSessionDialog_View;
                    window.Close();

                };
            }
        }


    }
}
