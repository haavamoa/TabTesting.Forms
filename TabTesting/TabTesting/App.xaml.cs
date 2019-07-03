using System;
using TabTesting.ViewModels;
using TabTesting.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabTesting
{
    public partial class App : Application
    {
        private readonly MainViewModel m_mainViewModel;

        public App()
        {
            InitializeComponent();
            var drugsViewModel = new DrugsViewModel();
            var vitalsViewModel = new VitalsViewModel();
            m_mainViewModel = new MainViewModel(drugsViewModel, vitalsViewModel);

            MainPage = new MainPage(m_mainViewModel);
        }

        protected override void OnStart()
        {
            m_mainViewModel.Initialize();
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
