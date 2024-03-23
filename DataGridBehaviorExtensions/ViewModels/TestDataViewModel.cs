using DataGridBehaviorExtensions.ViewModels.Base;

namespace DataGridBehaviorExtensions.ViewModels
{
    internal class TestDataViewModel : ViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public string TypeDescription { get; set; } = string.Empty;
    }
}
