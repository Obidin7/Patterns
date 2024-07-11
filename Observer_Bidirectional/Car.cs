using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Observer_Bidirectional;

public class Car : INotifyPropertyChanged
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value == name) return;
            name = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString() => $"Car: {Name}";
}
