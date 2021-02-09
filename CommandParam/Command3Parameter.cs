using System.Windows;

namespace CommandParam
{
    // MEMO: このクラスでコマンドの実施不可理由などを公開すると、理由のツールチップ表示などの実装が容易。

    public class Command3Parameter : CommandParameterBase<Command3Parameter>
    {
        public static DependencyProperty Int1Property = DependencyProperty.Register(
            nameof(Int1), typeof(int), typeof(Command3Parameter), new PropertyMetadata(0, RequerySuggest));

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
