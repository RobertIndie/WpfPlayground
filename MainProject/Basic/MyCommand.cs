using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RE.MainProject.Basic
{
    public class MyCommand : ICommand
    {
        public MyCommand(Action<object> execute): this(execute, null)
        {
        }
        public MyCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        private Action<object> _execute;
        private Func<object, bool> _canExecute;
       

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return true;
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if(_execute != null && CanExecute(parameter))
            {
                _execute(parameter);
            }
        }
    }
}
