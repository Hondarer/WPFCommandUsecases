using System.Windows;

namespace CommandParam
{
    public class Command3Parameter : CommandParameterBase<Command3Parameter>
    {
        public static DependencyProperty Int1Property = DependencyProperty.Register(
            nameof(Int1), typeof(int), typeof(Command3Parameter), new PropertyMetadata(0, OnNeedRequerySuggest));

        public int Int1
        {
            get 
            { 
                return (int)GetValue(Int1Property); 
            }
            set 
            { 
                SetValue(Int1Property, value);
            }
        }
    }
}
