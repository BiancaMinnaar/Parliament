using System;
using Parliament.Implementation.ViewController;
using Parliament.Implementation.ViewModel;
using Parliament.Root.View;
using Xamarin.Forms;

namespace Parliament.Implementation.View
{
    public partial class HomeDetailView : ProjectBaseContentView<HomeDetailViewController, HomeDetailViewModel>
    {
        public HomeDetailView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_FetchDashboard_Event(object sender, EventArgs e)
        {
            await _ViewController.FetchDashboard();
        }
    }
}


