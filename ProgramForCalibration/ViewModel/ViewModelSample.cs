using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProgramForCalibration.ViewModel
{
    public class ViewModelSample : BaseViewModel
    {
        public ViewModelSample(string name, int value)
        {
            Name = name;
            Value = value;
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        private int _Value;

        public int Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                Status = value > 100;
                OnPropertyChanged();
            }
        }
        private bool _Status;

        public bool Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                StatusBackground = Status ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
                OnPropertyChanged();
            }
        }
        private Brush _StatusBackground = new SolidColorBrush(Colors.White);

        public Brush StatusBackground
        {
            get
            {
                return _StatusBackground;
            }
            set
            {
                _StatusBackground = value;
                OnPropertyChanged();
            }
        }



    }
}
