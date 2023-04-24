using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AprLoaderNew.ViewModel
{
    public abstract class OnPropertyChangedClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
