using System;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace CommandParam
{
    // Button 等の CommandPatameter プロパティは依存関係プロパティであるが、
    // ソースに追従してしてターゲットが変化しせたとき、関連する Command の CanExecute を再評価しないため、
    // 条件が変化しても見た目の活性非活性が追従しない現象が発生する場合がある。
    //
    // このビヘイビアは、CommandParameter の変化をきっかけに、Command の CanExecute を
    // 要求するものである。

    public class CanExecuteUpdateBehavior : Behavior<ButtonBase>
    {
        protected override void OnAttached()
        {
            DependencyPropertyDescriptor descripter = DependencyPropertyDescriptor.FromProperty(ButtonBase.CommandParameterProperty, typeof(ButtonBase));
            descripter.AddValueChanged(AssociatedObject, OnCommandParameterChanged);

            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            DependencyPropertyDescriptor descripter = DependencyPropertyDescriptor.FromProperty(ButtonBase.CommandParameterProperty, typeof(ButtonBase));
            descripter.RemoveValueChanged(AssociatedObject, OnCommandParameterChanged);
        }

        private void OnCommandParameterChanged(object sender, EventArgs e)
        {
            if ((sender as ButtonBase).Command is IRaiseCanExecuteChanged command)
            {
                command.RaiseCanExecuteChanged();
            }
        }
    }
}
