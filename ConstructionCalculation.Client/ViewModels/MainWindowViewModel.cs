using ConstructionCalculation.Client.ViewModels.Base;

namespace ConstructionCalculation.Client.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title = "Главная страница";

        public string Title
        {
            get => title;
            set => Set(ref title, value);
        }
    }
}
