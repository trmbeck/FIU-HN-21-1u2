using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Firstname = "Susi";
            Lastname = "Sorglos";
        }

        private string firstname;

        public string Firstname 
        { 
            get => firstname; 
            set
            {
                ArgumentNullException.ThrowIfNull(nameof(value));
                if (firstname != value)
                {
                    firstname = value;

                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Fullname));
                }   
            } 
        }

        private string lastname;
        public string Lastname
        {
            get => lastname;
            set
            {
                ArgumentNullException.ThrowIfNull(nameof(value));
                if (lastname != value)
                {
                    lastname = value;

                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Fullname));
                }
            }
        }

        public string Fullname
        {
            get => $"{Firstname} {Lastname}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (!string.IsNullOrEmpty(propertyName))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
