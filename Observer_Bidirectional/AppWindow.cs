using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Observer_Bidirectional;

public class AppWindow : INotifyPropertyChanged
{
    private string carName;

    public string CarName
    {
        get => carName;
        set
        {
            if (value == carName) return;
            carName = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString() => $"App Window: {CarName}";
}
