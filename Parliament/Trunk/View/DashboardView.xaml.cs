using System;
using Parliament.Implementation.ViewController;
using Parliament.Implementation.ViewModel;
using Parliament.Root.View;
using Xamarin.Forms;

namespace Parliament.Implementation.View
{
    public partial class DashboardView : ProjectBaseContentPage<DashboardViewController, DashboardViewModel>
    {
        public DashboardView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_Load_Event(object sender, EventArgs e)
        {
            await _ViewController.Load();
        }
    }
}


