using System;
using Parliament.Implementation.ViewController;
using Parliament.Implementation.ViewModel;
using Parliament.Root.View;
using Xamarin.Forms;

namespace Parliament.Implementation.View
{
    public partial class StandardTableItemView : ProjectBaseContentView<StandardTableItemViewController, StandardTableItemViewModel>
    {
        public StandardTableItemView(Xamarin.Forms.View viewToShow)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail.Content = viewToShow;
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public async void On_StandardTableItem_Event_Event(object sender, EventArgs e)
        {
            await _ViewController.StandardTableItem_Event();
        }
    }
}


