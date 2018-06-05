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
    public class DashboardViewController : ProjectBaseViewController<DashboardViewModel>, IDashboardViewController
    {
        IDashboardRepository<DashboardViewModel> _Reposetory;
        IDashboardService<DashboardViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new DashboardService<DashboardViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<DashboardViewModel>(U, P, C, A));
            _Reposetory = new DashboardRepository<DashboardViewModel>(_MasterRepo, _Service);
        }

        public async Task Load()
        {
            
        }
    }
}