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
    class MainViewModel : BaseViewModel
    {
        public Model.HP3457_Model hP_3457;
        public MainViewModel()
        {

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
                    vm.hP_3457 = new Model.HP3457_Model(gpibSession);

                    var window = new View.OpenSessionDialog_View();
                    window.Create(vm_dialog);
                    window.ShowDialog();
                  
                    
                   

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
                    
                    



                };
            }
        }



    }
}
