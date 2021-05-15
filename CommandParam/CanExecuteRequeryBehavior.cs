using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace CommandParam
{
    /// <summary>
    /// <see cref="ICommandSource"/> にパラメーターの変化に応じた自動再評価機能を付与します。
    /// </summary>
    public class CanExecuteRequeryBehavior : Behavior<DependencyObject>
    {
        /// <inheritdoc/>
        protected override void OnAttached()
        {
            // ビヘイビアの対象が ICommandSource の場合、CommandParameter プロパティの変化を購読開始する。
            if (AssociatedObject is ICommandSource commandSource)
            {
                DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromName(nameof(ICommandSource.CommandParameter), commandSource.GetType(), commandSource.GetType(), true);
                descriptor.AddValueChanged(AssociatedObject, OnCommandParameterChanged);
            }

            base.OnAttached();
        }

        /// <inheritdoc/>
        protected override void OnDetaching()
        {
            base.OnDetaching();

            // 購読終了。
            if (AssociatedObject is ICommandSource commandSource)
            {
                DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromName(nameof(ICommandSource.CommandParameter), commandSource.GetType(), commandSource.GetType(), true);
                descriptor.RemoveValueChanged(AssociatedObject, OnCommandParameterChanged);
            }
        }

        /// <summary>
        /// 対象の <see cref="ICommandSource.CommandParameter"/> が変化した際の処理を行います。
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void OnCommandParameterChanged(object sender, EventArgs e)
        {
            // CommandParameter を取り出す。
            object commandParameter = (sender as ICommandSource).CommandParameter;

            // CommandParameter が CommandParameterBase の派生でない(CommandParameterBase は RaiseCanExecuteChanged 呼び出し機能を持つ) かつ
            // Command が IRaiseCanExecuteChanged による外部からの実行可否判定をサポートしているかどうか判定
            if ((commandParameter != null) &&
                (commandParameter.GetType().IsSubclassOfGeneric(typeof(CommandParameterBase<>)) == false) &&
                ((sender as ICommandSource).Command is IRaiseCanExecuteChanged command))
            {
                // コマンドの再評価を行う。
                command.RaiseCanExecuteChanged();
            }
        }
    }
}
