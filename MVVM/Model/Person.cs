using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string _fName;

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }// OnPropertyChanged(FName); }
        }

        private string _lName;

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }// OnPropertyChanged(LName); }
        }


        private string _fullName;

        public string FullName
        {
            get { return FullName = FName + " " + LName; }
            set { _fullName = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string s)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
            {
                ph(this, new PropertyChangedEventArgs(s));
            }
        }
    }
}
