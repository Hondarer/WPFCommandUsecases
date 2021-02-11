using System;
using System.Windows.Input;

namespace CommandParam
{
    public abstract class CommandBase : ICommand, IRaiseCanExecuteChanged, IDisposable
    {
        #region IDisposable

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                CommandManager.RequerySuggested -= RequerySuggested;

                disposedValue = true;
            }
        }

        ~CommandBase()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion

        public event EventHandler CanExecuteChanged;

        public virtual void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public CommandBase()
        {
            CommandManager.RequerySuggested += RequerySuggested;
        }

        protected virtual void RequerySuggested(object sender, EventArgs e)
        {
            RaiseCanExecuteChanged();
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
