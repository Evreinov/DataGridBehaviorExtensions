using System.Windows;
using DataGridBehaviorExtensions.Interfaces;
using DataGridBehaviorExtensions.Services;
using DataGridBehaviorExtensions.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DataGridBehaviorExtensions;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private static IServiceProvider? _services;

    public static IServiceProvider Services => _services ??= _services = GetServices().BuildServiceProvider();

    private static IServiceCollection GetServices()
    {
        var services = new ServiceCollection();
        InitializeServices(services);
        return services;
    }

    private static void InitializeServices(IServiceCollection services)
    {
        services.AddSingleton<MainWindowViewModel>();
        services.AddSingleton<ITestDataService>(new TestDataService());
    }
}