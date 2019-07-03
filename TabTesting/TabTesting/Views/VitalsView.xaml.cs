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
    public partial class VitalsView : ContentPage
    {
        private VitalsViewModel m_vitalsViewModel;

        public VitalsView(VitalsViewModel vitalsViewModel)
        {
            InitializeComponent();
            m_vitalsViewModel = vitalsViewModel;
            BindingContext = vitalsViewModel;
        }
    }
}