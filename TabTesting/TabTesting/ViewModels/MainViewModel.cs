using System.Security.Cryptography.X509Certificates;
using TabTesting.Models;

namespace TabTesting.ViewModels
{
    public class MainViewModel
    {

        public MainViewModel(DrugsViewModel drugsViewModel, VitalsViewModel vitalsViewModel)
        {
            DrugsViewModel = drugsViewModel;
            VitalsViewModel = vitalsViewModel;
        }

        public VitalsViewModel VitalsViewModel { get; }
        public DrugsViewModel DrugsViewModel { get;  }

        public void Initialize()
        {
            var age = new Age();
            DrugsViewModel.Initialize(age);
            VitalsViewModel.Initialize(age);
        }
    }
}