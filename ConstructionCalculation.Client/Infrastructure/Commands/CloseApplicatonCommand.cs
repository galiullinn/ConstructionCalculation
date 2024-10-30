using ConstructionCalculation.Client.Infrastructure.Commands.Base;
using System.Windows;

namespace ConstructionCalculation.Client.Infrastructure.Commands
{
    internal class CloseApplicatonCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
