using Parliament.Root;
using Parliament.Root.Repository;
using Parliament.Root.ViewController;
using Parliament.Root.ViewModel;
using Parliament.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace Parliament.Root.View
{
    public abstract class ProjectBaseContentPage<T, M> : ContentPage
        where T: ProjectBaseViewController<M>, new()
        where M: ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPage()
        {
            _ViewController = new T();
            _ViewController.InputObject = new M();
            SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}

