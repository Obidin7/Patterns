namespace Observer_Interfaces;

public class Person : PropertyNotificationSupport
{
    private const int AgeAllowed = 16;
    private int age;

    public int Age
    {
        get => age;
        set => SetValue(value, ref age);
    }

    public bool AlcoholAllowed
    {
        get => alcoholAllowed;
        set => SetValue(value, ref alcoholAllowed);
    }

    private readonly Func<bool> cigarettesAllowed;
    private bool alcoholAllowed;
    public bool CigarettesAllowed => cigarettesAllowed();

    public Person()
    {
        cigarettesAllowed = Property(
          nameof(CigarettesAllowed),
          () => AlcoholAllowed && Age >= AgeAllowed);
    }
}
