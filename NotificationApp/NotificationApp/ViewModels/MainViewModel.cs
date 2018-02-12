using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NotificationApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string firebaseMessage;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirebaseMessage
        {
            get => this.firebaseMessage;
            set
            {
                if (this.firebaseMessage != value)
                {
                    this.firebaseMessage = value;
                    this.OnPropertyChanged(nameof(this.FirebaseMessage));
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}