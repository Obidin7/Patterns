using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Observer_Interfaces;

public class PropertyNotificationSupport : INotifyPropertyChanged, INotifyPropertyChanging
{
    private readonly Dictionary<string, HashSet<string>> affectedBy = [];

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged
      ([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        foreach (var affected in affectedBy.Keys)
            if (affectedBy[affected].Contains(propertyName))
                OnPropertyChanged(affected);
    }

    protected Func<T> Property<T>(string name, Expression<Func<T>> expr)
    {
        Console.WriteLine($"Creating computed property for expression {expr}");

        var visitor = new MemberAccessVisitor(GetType());
        visitor.Visit(expr);

        if (visitor.PropertyNames.Any())
        {
            if (!affectedBy.ContainsKey(name))
                affectedBy.Add(name, []);

            foreach (var propName in visitor.PropertyNames)
                if (propName != name)
                    affectedBy[name].Add(propName);
        }

        return expr.Compile();
    }

    private class MemberAccessVisitor : ExpressionVisitor
    {
        private readonly Type declaringType;
        public readonly IList<string> PropertyNames = new List<string>();

        public MemberAccessVisitor(Type declaringType) => this.declaringType = declaringType;

        public override Expression Visit(Expression expr)
        {
            if (expr != null && expr.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpr = (MemberExpression)expr;
                if (memberExpr.Member.DeclaringType == declaringType)
                {
                    PropertyNames.Add(memberExpr.Member.Name);
                }
            }

            return base.Visit(expr);
        }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    protected virtual void OnPropertyChanging(
      [CallerMemberName] string propertyName = null)
    {
        PropertyChanging?.Invoke(this,
          new PropertyChangingEventArgs(propertyName));
    }

    protected void SetValue<T>(T value, ref T field,
      [CallerMemberName] string propertyName = null)
    {
        if (value.Equals(field)) return;
        OnPropertyChanging(propertyName);
        field = value;
        OnPropertyChanged(propertyName);
    }
}
