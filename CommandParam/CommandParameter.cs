using System.Windows;

namespace CommandParam
{
    public class CommandParameter : CommandParameterBase<CommandParameter>
    {
        public static DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value), typeof(object), typeof(CommandParameter), new PropertyMetadata(null, RequerySuggest));

        public object Value
        {
            get
            {
                return GetValue(ValueProperty);
            }
            set
            {
                SetValue(ValueProperty, value);
            }
        }
    }
}
