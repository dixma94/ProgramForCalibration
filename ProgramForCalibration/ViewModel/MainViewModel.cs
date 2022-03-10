using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace ProgramForCalibration.ViewModel
{
   public class MainViewModel : BaseViewModel
    {
        public Model.HP3457_Model hP_3457;
        public MainViewModel()
        {

        }

        private string _Text;

        public string Text
        {
            get { return _Text; }
            set { _Text = value;
                OnPropertyChanged();
            }
        }
       
        private ObservableCollection<DeviceVM> _DeviceCollection = new ObservableCollection<DeviceVM>();

        public ObservableCollection<DeviceVM> DeviceCollection
        {
            get { return _DeviceCollection; }
            set { _DeviceCollection = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<CommandVM> _CommandCollection = new ObservableCollection<CommandVM>();

        public ObservableCollection<CommandVM> CommandCollection
        {
            get { return _CommandCollection; }
            set { _CommandCollection = value;
                OnPropertyChanged();
            }
        }

        public static ExecutedRoutedEventHandler AddDevice
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {
                    var vm = e.Parameter as MainViewModel;
                    Model.GpibSession gpibSession =  new Model.GpibSession();
                    OpenSessionDialog_VM vm_dialog = new OpenSessionDialog_VM(gpibSession);
                    

                    var window = new View.OpenSessionDialog_View();
                    window.Create(vm_dialog);
                    window.ShowDialog();
                    vm.DeviceCollection.Add(new DeviceVM(new Model.HP3457_Model(gpibSession),vm));
                    //vm.hP_3457.RESET();
                    //vm.hP_3457.BEEP(Model.HP3457_Model.Beep_type.OFF);
                    



                };
            }
        }
        public static ExecutedRoutedEventHandler Read
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {
                    var vm = e.Parameter as MainViewModel;
                    //vm.hP_3457.TARM(Model.HP3457_Model.TARM_type.HOLD);
                    //vm.Text= vm.hP_3457.Read();
                    

                    vm.hP_3457.TARM(Model.HP3457_Model.TARM_type.SGL, 1);
                    vm.Text= vm.hP_3457.Read();




                };
            }
        }



    }
}
