using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace CommandParam
{
    /// <summary>
    /// 自動再評価機能を備えたバインディング可能なコマンドパラメーターの基底クラスを提供します。
    /// </summary>
    /// <typeparam name="T">本クラスを継承した実クラス。</typeparam>
    public abstract class CommandParameterBase<T> : Freezable where T : new()
    {
        /// <summary>
        /// InheritanceContext プロパティの <see cref="PropertyInfo"/> を保持します。このフィールドは読み取り専用です。
        /// </summary>
        private static readonly PropertyInfo InheritanceContextProperty = 
            typeof(DependencyObject).GetProperty("InheritanceContext", BindingFlags.NonPublic | BindingFlags.Instance);

        /// <summary>
        /// このオブジェクトの継承元の <see cref="System.Windows.FrameworkElement"/> を取得します。
        /// </summary>
        public FrameworkElement FrameworkElement
        {
            get
            {
                if (InheritanceContextProperty.GetValue(this) is FrameworkElement frameworkElement)
                {
                    return frameworkElement;
                }

                return null;
            }
        }

        /// <summary>
        /// このオブジェクトの継承元の <see cref="System.Windows.FrameworkElement"/> の <see cref="FrameworkElement.DataContext"/> を取得します。
        /// </summary>
        public object DataContext
        {
            get
            {
                if (FrameworkElement != null)
                {
                    return FrameworkElement.DataContext;
                }

                return null;
            }
        }

        /// <summary>
        /// 依存関係プロパティが変化した際の処理を行います。
        /// </summary>
        /// <param name="sender">The System.Windows.DependencyObject on which the property has changed value.</param>
        /// <param name="e">Event data that is issued by any event that tracks changes to the effective value of this property.</param>
        protected static void RequerySuggest(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // 前後が同じ値であれば処理しない。
            if (e.OldValue == e.NewValue)
            {
                return;
            }

            // インスタンスの再評価依頼処理に委譲する。
            if (sender is CommandParameterBase<T>)
            {
                (sender as CommandParameterBase<T>).RequerySuggest();
            }
        }

        /// <summary>
        /// このオブジェクトの継承元に、コマンドの再評価を依頼します。
        /// </summary>
        protected void RequerySuggest()
        {
            OnRequerySuggest();

            // 継承元が ICommandSource か
            if (InheritanceContextProperty.GetValue(this) is ICommandSource commandSource)
            {
                // ICommandSource は、IRaiseCanExecuteChanged インターフェースを実装しているか
                if (commandSource.Command is IRaiseCanExecuteChanged command)
                {
                    // 再評価を依頼
                    command.RaiseCanExecuteChanged();
                }
            }

            RequerySuggested();
        }

        /// <summary>
        /// 再評価依頼前の処理を行います。
        /// </summary>
        protected virtual void OnRequerySuggest()
        {
        }

        /// <summary>
        /// 再評価依頼後の処理を行います。
        /// </summary>
        protected virtual void RequerySuggested()
        {
        }

        /// <inheritdoc/>
        protected override Freezable CreateInstanceCore()
        {
            return new T() as Freezable;
        }
    }
}
