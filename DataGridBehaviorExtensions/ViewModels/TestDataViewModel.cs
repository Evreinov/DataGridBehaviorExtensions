using System.ComponentModel;
using DataGridBehaviorExtensions.ViewModels.Base;

namespace DataGridBehaviorExtensions.ViewModels
{
    internal class TestDataViewModel : ViewModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Описание")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Тип")]
        public string Type { get; set; } = string.Empty;

        [DisplayName("Описание типа")]
        public string TypeDescription { get; set; } = string.Empty;
    }
}
