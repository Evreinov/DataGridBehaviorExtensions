using DataGridBehaviorExtensions.Models;

namespace DataGridBehaviorExtensions.Interfaces;

internal interface ITestDataService
{
    IEnumerable<TestData> GenerateTestData(int count);
}