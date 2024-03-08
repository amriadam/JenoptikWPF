using System.Reflection.Metadata.Ecma335;
using System.Windows.Input;

namespace JenoptikWPF.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Func<object?, bool> canExecute;

        public RelayCommand(Action<object?> execute, Func<object?, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return this.canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            this.execute(parameter);

        }

        public void InvokeCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}