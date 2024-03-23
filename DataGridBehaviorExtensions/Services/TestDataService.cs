using DataGridBehaviorExtensions.Interfaces;
using DataGridBehaviorExtensions.Models;

namespace DataGridBehaviorExtensions.Services
{
    internal class TestDataService : ITestDataService
    {
        public IEnumerable<TestData> GenerateTestData(int count)
        {
            return Enumerable.Range(0, count)
                .Select(_ => new TestData
                {
                    Id = _,
                    Name = $"Наименование {_:D6}",
                    Description = $"Описание {_}",
                    Type = $"Тип {_:D6}",
                    TypeDescription = $"Описание типа {_}",
                });
        }
    }
}
