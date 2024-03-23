using DataGridBehaviorExtensions.Infrastructure.Commands;
using DataGridBehaviorExtensions.Interfaces;
using DataGridBehaviorExtensions.Models;
using DataGridBehaviorExtensions.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataGridBehaviorExtensions.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    private readonly ITestDataService _testDataService;

    #region Title : string - Заголовок окна.
    /// <summary>Заголовок окна.</summary>
    private string? _title = "Главное окно";

    /// <summary>Заголовок окна.</summary>
    public string? Title
    {
        get => _title;
        set => Set(ref _title, value);
    }
    #endregion

    #region Collection : ObservableCollection<TestData> - Коллекция с тестовыми данными.
    /// <summary>Коллекция с тестовыми данными.</summary>
    private ObservableCollection<TestData> _collection = new();

    /// <summary>Коллекция с тестовыми данными.</summary>
    public ObservableCollection<TestData> Collection
    {
        get => _collection;
        set => Set(ref _collection, value);
    }
    #endregion

    #region Команды

    private readonly ICommand _generateDataCommand;
    
    public ICommand GenerateDataCommand => _generateDataCommand;

    private void OnGenerateDataCommandExecute(object? obj)
    {
        var collection = _testDataService.GenerateTestData(10);
        Collection = new ObservableCollection<TestData>(collection);
    }

    #endregion

    public MainWindowViewModel(ITestDataService testDataService)
    {
        _testDataService = testDataService;
        _generateDataCommand = new RelayCommand(OnGenerateDataCommandExecute);
    }
}