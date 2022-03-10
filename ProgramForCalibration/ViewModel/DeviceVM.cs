using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProgramForCalibration.Model;

namespace ProgramForCalibration.ViewModel
{
   public class DeviceVM: BaseViewModel
    {
        public IDevice model;
        public MainViewModel MainViewModel;
        public DeviceVM(IDevice model, MainViewModel mainViewModel)
        {
            this.model = model;
            this.MainViewModel = mainViewModel;
        }

       

        public string Name
        {
            get { return model.Name; }
            set { model.Name = value; }
        }

        public static ExecutedRoutedEventHandler AddCommand
        {
            get
            {
                return (object sender, ExecutedRoutedEventArgs e) =>
                {
                    var vm = e.Parameter as DeviceVM;
                    vm.MainViewModel.CommandCollection.Add(new CommandVM());




                };
            }
        }
    }
}
