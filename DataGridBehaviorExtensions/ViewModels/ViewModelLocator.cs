using Microsoft.Extensions.DependencyInjection;

namespace DataGridBehaviorExtensions.ViewModels;

internal class ViewModelLocator
{
    public MainWindowViewModel MainWindow => App.Services.GetRequiredService<MainWindowViewModel>();
}