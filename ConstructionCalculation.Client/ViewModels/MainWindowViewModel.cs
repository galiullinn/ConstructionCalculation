using ConstructionCalculation.Client.ViewModels.Base;

namespace ConstructionCalculation.Client.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Главная страница";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}
