using System.Reflection;
using System.Windows;

namespace CommandParam
{
    public class CommandParameterBase<T> : Freezable where T : new()
    {
        private static readonly PropertyInfo InheritanceContextProperty = typeof(DependencyObject).GetProperty("InheritanceContext", BindingFlags.NonPublic | BindingFlags.Instance);

        protected static void RequerySuggest(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is CommandParameterBase<T>)
            {
                CommandParameterBase<T> commandParameterBase = obj as CommandParameterBase<T>;
                commandParameterBase.OnRequerySuggest();

                if (InheritanceContextProperty.GetValue(obj) is DependencyObject parent)
                {
                    PropertyInfo commandProperty = parent.GetType().GetProperty("Command", BindingFlags.Public | BindingFlags.Instance);

                    if ((commandProperty != null) && (commandProperty.GetValue(parent) is IRaiseCanExecuteChanged command))
                    {
                        command.RaiseCanExecuteChanged();
                    }
                }

                commandParameterBase.RequerySuggested();
            }
        }

        protected virtual void OnRequerySuggest()
        {
        }

        protected virtual void RequerySuggested()
        {
        }

        protected override Freezable CreateInstanceCore()
        {
            return new T() as Freezable;
        }
    }
}
