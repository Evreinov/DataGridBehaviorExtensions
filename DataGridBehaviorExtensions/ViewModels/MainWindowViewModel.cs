using DataGridBehaviorExtensions.Infrastructure.Commands;
using DataGridBehaviorExtensions.Interfaces;
using DataGridBehaviorExtensions.Models;
using DataGridBehaviorExtensions.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DataGridBehaviorExtensions.Infrastructure.Mappers;

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

    #region Collection : ObservableCollection<TestDataViewModel> - Коллекция с тестовыми данными.
    /// <summary>Коллекция с тестовыми данными.</summary>
    private ObservableCollection<TestDataViewModel> _collection = new();

    /// <summary>Коллекция с тестовыми данными.</summary>
    public ObservableCollection<TestDataViewModel> Collection
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
        var collection = _testDataService.GenerateTestData(10).Select(_ => _.ToViewModel());
        Collection = new ObservableCollection<TestDataViewModel>(collection);
    }

    #endregion

    public MainWindowViewModel(ITestDataService testDataService)
    {
        _testDataService = testDataService;
        _generateDataCommand = new RelayCommand(OnGenerateDataCommandExecute);
    }
}