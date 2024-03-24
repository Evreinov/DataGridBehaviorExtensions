using Microsoft.Xaml.Behaviors;
using System.Windows.Controls;

namespace DataGridBehaviorExtensions.Infrastructure.Controls.Behaviors;

public class DataGridGenerateColumnsBehavior : Behavior<DataGrid>
{
    protected override void OnAttached()
    {
        base.OnAttached();
        this.AssociatedObject.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        this.AssociatedObject.AutoGeneratingColumn -= DataGrid_AutoGeneratingColumn;
    }

    private void DataGrid_AutoGeneratingColumn(object? sender, DataGridAutoGeneratingColumnEventArgs e) =>
        e.Column.Header = ((System.ComponentModel.PropertyDescriptor)e.PropertyDescriptor).DisplayName;
}