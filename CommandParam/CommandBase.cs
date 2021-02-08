using System;
using System.Windows.Input;

namespace CommandParam
{
    public abstract class CommandBase : ICommand, IRaiseCanExecuteChanged
    {
        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
