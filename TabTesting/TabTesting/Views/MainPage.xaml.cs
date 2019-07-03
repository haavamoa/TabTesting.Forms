using System;
using System.ComponentModel;
using TabTesting.ViewModels;
using Xamarin.Forms;

namespace TabTesting.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        private MainViewModel m_mainViewModel;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            m_mainViewModel = mainViewModel;
            BindingContext = mainViewModel;

            var drugsView = new DrugsView(mainViewModel.DrugsViewModel);
            var vitalsView = new VitalsView(mainViewModel.VitalsViewModel);
            this.Children.Add(new NavigationPage(drugsView){Title = "Drugs"});
            this.Children.Add(new NavigationPage(vitalsView) {Title = "Vitals"});
            this.CurrentPageChanged += OnCurrentPageChanged; 
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            if (sender is MainPage mainPage)
            {
                if (mainPage.CurrentPage is NavigationPage navigationPage)
                {
                    if (navigationPage.CurrentPage is DrugsView)
                    {
                        m_mainViewModel.DrugsViewModel.Recalculate();
                        m_mainViewModel.DrugsViewModel.OnPropertyChanged(string.Empty);
                    }

                    if (navigationPage.CurrentPage is VitalsView)
                    {
                        m_mainViewModel.VitalsViewModel.Recalculate();
                        m_mainViewModel.VitalsViewModel.OnPropertyChanged(string.Empty);
                    }
                }
            }
        }
    }
}
