using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace CommandParam
{
    public class CanExecuteRequeryBehavior : Behavior<DependencyObject>
    {
        protected override void OnAttached()
        {
            if (AssociatedObject is ICommandSource commandSource)
            {
                DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromName(nameof(ICommandSource.CommandParameter), commandSource.GetType(), commandSource.GetType(), true);
                descriptor.AddValueChanged(AssociatedObject, OnCommandParameterChanged);
            }

            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            if (AssociatedObject is ICommandSource commandSource)
            {
                DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromName(nameof(ICommandSource.CommandParameter), commandSource.GetType(), commandSource.GetType(), true);
                descriptor.RemoveValueChanged(AssociatedObject, OnCommandParameterChanged);
            }
        }

        private void OnCommandParameterChanged(object sender, EventArgs e)
        {
            object commandParameter = (sender as ICommandSource).CommandParameter;

            if ((commandParameter != null) &&
                (!commandParameter.GetType().IsSubclassOfGeneric(typeof(CommandParameterBase<>))) &&
                ((sender as ICommandSource).Command is IRaiseCanExecuteChanged command))
            {
                command.RaiseCanExecuteChanged();
            }
        }
    }
}
