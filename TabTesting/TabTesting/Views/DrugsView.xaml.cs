using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabTesting.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabTesting.Views
{
    public partial class DrugsView : ContentPage
    {
        private DrugsViewModel m_drugsViewModel;

        public DrugsView(DrugsViewModel drugsViewModel)
        {
            InitializeComponent();
            m_drugsViewModel = drugsViewModel;
            BindingContext = drugsViewModel;
        }
    }
}