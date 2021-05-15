using System.Windows.Input;

namespace CommandParam
{
    /// <summary>
    /// 外部から <see cref="ICommand.CanExecuteChanged"/> の発火を依頼するインターフェースを提供します。
    /// </summary>
    public interface IRaiseCanExecuteChanged
    {
        /// <summary>
        /// <see cref="ICommand.CanExecuteChanged"/> の発火を依頼します。
        /// </summary>
        void RaiseCanExecuteChanged();
    }
}
