using System.Reflection;
using System.Windows;

namespace CommandParam
{
    public class CommandParameterBase<T> : Freezable where T : new()
    {
        private static readonly PropertyInfo InheritanceContextProperty = typeof(DependencyObject).GetProperty("InheritanceContext", BindingFlags.NonPublic | BindingFlags.Instance);

        protected static void OnNeedRequerySuggest(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if ((obj != null) && (InheritanceContextProperty.GetValue(obj) is DependencyObject parent))
            {
                PropertyInfo commandProperty = parent.GetType().GetProperty("Command", BindingFlags.Public | BindingFlags.Instance);

                if ((commandProperty != null) && (commandProperty.GetValue(parent) is IRaiseCanExecuteChanged command))
                {
                    command.RaiseCanExecuteChanged();
                }
            }
        }

        protected override Freezable CreateInstanceCore()
        {
            return new T() as Freezable;
        }
    }
}
