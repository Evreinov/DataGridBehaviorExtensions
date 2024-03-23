using System.Windows;
using DataGridBehaviorExtensions.Infrastructure.Commands.Base;

namespace DataGridBehaviorExtensions.Infrastructure.Commands;

internal class RelayCommand : Command
{
    private readonly Action<object?> _execute;

    private readonly Func<object?, bool>? _canExecute;

    public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
    {
        ArgumentNullException.ThrowIfNull(execute);
        _execute = execute;
        _canExecute = canExecute;
    }

    public RelayCommand(Action<object?> execute, Func<bool>? canExecute) : this (execute, canExecute is null ? null : _ => canExecute!()) { }

    public RelayCommand(Action execute, Func<object?, bool>? canExecute = null) : this(_ => execute(), canExecute) { }

    public RelayCommand(Action execute, Func<bool>? canExecute) : this(_ => execute(), canExecute is null ? null : _ => canExecute!()) { }

    protected override bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

    protected override void Execute(object? parameter) => _execute(parameter);
}