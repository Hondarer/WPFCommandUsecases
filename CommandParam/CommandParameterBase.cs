using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace CommandParam
{
    public abstract class CommandParameterBase<T> : Freezable where T : new()
    {
        private static readonly PropertyInfo InheritanceContextProperty = typeof(DependencyObject).GetProperty("InheritanceContext", BindingFlags.NonPublic | BindingFlags.Instance);

        public UIElement UIElement
        {
            get
            {
                if (InheritanceContextProperty.GetValue(this) is UIElement uiElement)
                {
                    return uiElement;
                }

                return null;
            }
        }

        public object DataContext
        {
            get
            {
                if (UIElement is FrameworkElement frameworkElement)
                {
                    return frameworkElement.DataContext;
                }

                return null;
            }
        }

        protected static void RequerySuggest(DependencyObject obj, DependencyPropertyChangedEventArgs _)
        {
            if (obj is CommandParameterBase<T>)
            {
                CommandParameterBase<T> commandParameterBase = obj as CommandParameterBase<T>;
                commandParameterBase.OnRequerySuggest();

                if (InheritanceContextProperty.GetValue(obj) is ICommandSource parent)
                {
                    if (parent.Command is IRaiseCanExecuteChanged command)
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
