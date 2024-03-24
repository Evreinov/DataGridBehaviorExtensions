using DataGridBehaviorExtensions.Models;
using DataGridBehaviorExtensions.ViewModels;

namespace DataGridBehaviorExtensions.Infrastructure.Mappers
{
    internal static class Mapper
    {
        internal static TestDataViewModel ToViewModel(this TestData model)
        {
            return new TestDataViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Type = model.Type,
                TypeDescription = model.TypeDescription,
            };
        }
    }
}
