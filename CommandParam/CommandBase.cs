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

        public CommandBase()
        {
            CommandManager.RequerySuggested += RequerySuggested;
        }

        ~CommandBase()
        {
            CommandManager.RequerySuggested -= RequerySuggested;
        }

        private void RequerySuggested(object sender, EventArgs e)
        {
            RaiseCanExecuteChanged();
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
