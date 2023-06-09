﻿using System;

namespace AprLoaderNew
{
    /// <summary>
    /// Класс для выполнения команд
    /// </summary>
    public class RelayCommand : System.Windows.Input.ICommand
    {

        /// <summary>
        /// Действие при вызове команды
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Проверка возможности выполнения команды
        /// </summary>
        private readonly Predicate<object> _canExecute;

        public Action CleanUpWorkspaceM { get; }

        /// <summary>
        /// конструктор класса <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">Действие которое будет выполнятся</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">Действие которое будет выполнятся</param>
        /// <param name="canExecute">Проверка возможности выполнения команды</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException();
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action cleanUpWorkspaceM)
        {
            CleanUpWorkspaceM = cleanUpWorkspaceM;
        }

        #region ICommand Members

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { System.Windows.Input.CommandManager.RequerySuggested += value; }
            remove { System.Windows.Input.CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion
    }
}
