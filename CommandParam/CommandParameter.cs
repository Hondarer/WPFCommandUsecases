using System.Windows;

namespace CommandParam
{
    /// <summary>
    /// 自動再評価機能を備えたバインディング可能な汎用コマンドパラメーターを提供します。
    /// </summary>
    public sealed class CommandParameter : CommandParameterBase<CommandParameter>
    {
        /// <summary>
        /// Value 依存関係プロパティを識別します。このフィールドは読み取り専用です。
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value), typeof(object), typeof(CommandParameter), new PropertyMetadata(null, RequerySuggest));

        /// <summary>
        /// コマンドパラメーターの値を取得または設定します。
        /// </summary>
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
