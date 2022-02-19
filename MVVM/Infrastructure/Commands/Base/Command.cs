﻿using System;
using System.Windows.Input;

namespace MVVM.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parametr);

        public abstract void Execute(object parametr);
    }
}
