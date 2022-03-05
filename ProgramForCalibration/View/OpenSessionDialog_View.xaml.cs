using ProgramForCalibration.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgramForCalibration.View
{
    /// <summary>
    /// Логика взаимодействия для OpenSessionDialog_View.xaml
    /// </summary>
    public partial class OpenSessionDialog_View : Window
    {
        OpenSessionDialog_VM vm;

        public OpenSessionDialog_View()
        {
            InitializeComponent();
        }
       
        
        public void Create(OpenSessionDialog_VM viewmodel)
        {
            vm = viewmodel;
            DataContext = vm;


        }

        private void list_box_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            vm.ConnectToDevice();
            this.Close();
        }
    }
}
