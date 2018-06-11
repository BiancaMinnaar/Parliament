using System.Threading.Tasks;
using Parliament.Implementation.Repository;
using Parliament.Implementation.Service;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Interface.ViewController;
using Parliament.Root.ViewController;

namespace Parliament.Implementation.ViewController
{
    public class HomeDetailViewController : ProjectBaseViewController<HomeDetailViewModel>, IHomeDetailViewController
    {
        IHomeDetailRepository<HomeDetailViewModel> _Reposetory;
        IHomeDetailService<HomeDetailViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new HomeDetailService<HomeDetailViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<HomeDetailViewModel>(U, P, C, A));
            _Reposetory = new HomeDetailRepository<HomeDetailViewModel>(_MasterRepo, _Service);
        }

        public async Task FetchDashboard()
        {
            
        }
    }
}