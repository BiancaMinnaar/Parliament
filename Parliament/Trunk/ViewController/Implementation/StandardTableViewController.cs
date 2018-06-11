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
    public class StandardTableViewController : ProjectBaseViewController<StandardTableViewModel>, IStandardTableViewController
    {
        IStandardTableRepository<StandardTableViewModel> _Reposetory;
        IStandardTableService<StandardTableViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new StandardTableService<StandardTableViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<StandardTableViewModel>(U, P, C, A));
            _Reposetory = new StandardTableRepository<StandardTableViewModel>(_MasterRepo, _Service);
        }

        public async Task StandardTable_Event()
        {
            
        }
    }
}