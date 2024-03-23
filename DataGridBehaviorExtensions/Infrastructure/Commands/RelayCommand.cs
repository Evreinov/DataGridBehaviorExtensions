﻿using DataGridBehaviorExtensions.Infrastructure.Commands.Base;

namespace DataGridBehaviorExtensions.Infrastructure.Commands;

internal class RelayCommand : Command
{
    private readonly Action<object?> _execute;

    private readonly Func<object?, bool>? _canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    protected override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

    protected override void Execute(object? parameter) => _execute(parameter);
}