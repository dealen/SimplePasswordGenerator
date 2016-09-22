using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PasswordGenerator.Utility
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(params string[] propertyNames)
        {
            if (PropertyChanged != null)
            {
                foreach (string property in propertyNames)
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
