using System;
using Parliament.Implementation.ViewController;
using Parliament.Implementation.ViewModel;
using Parliament.Root.View;
using Xamarin.Forms;

namespace Parliament.Implementation.View
{
    public partial class StandardTableView : ProjectBaseContentView<StandardTableViewController, StandardTableViewModel>
    {
        public StandardTableView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _ViewController.InputObject;
        }

        protected override void SetSVGCollection()
        {
        }

        public void AddNewView(Xamarin.Forms.View viewToAdd)
        {
            var item = new StandardTableItemView(viewToAdd);
            Table.Children.Add(item);
        }

        public void Clear()
        {
            Table.Children.Clear();
        }

        public async void On_StandardTable_Event_Event(object sender, EventArgs e)
        {
            await _ViewController.StandardTable_Event();
        }
    }
}


