using DataGridBehaviorExtensions.Infrastructure.Commands;
using DataGridBehaviorExtensions.Infrastructure.Mappers;
using DataGridBehaviorExtensions.Interfaces;
using DataGridBehaviorExtensions.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace DataGridBehaviorExtensions.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    private readonly ITestDataService _testDataService;

    #region Title : string - Заголовок окна.
    /// <summary>Заголовок окна.</summary>
    private string? _title = "Sample";

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

    #region Команда - сгенерировать данные.
    /// <summary>Команда - сгенерировать данные.</summary>
    private readonly ICommand _generateDataCommand;

    /// <summary>Команда - сгенерировать данные.</summary>
    public ICommand GenerateDataCommand => _generateDataCommand;

    /// <summary>Сгенерировать данные.</summary>
    private void OnGenerateDataCommandExecute()
    {
        var collection = _testDataService.GenerateTestData(10).Select(_ => _.ToViewModel());
        Collection = new ObservableCollection<TestDataViewModel>(collection);
    }
    #endregion

    #endregion

    public MainWindowViewModel(ITestDataService testDataService)
    {
        _testDataService = testDataService;

        _generateDataCommand = new RelayCommand(OnGenerateDataCommandExecute);
    }
}