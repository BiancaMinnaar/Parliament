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
    public class StandardTableItemViewController : ProjectBaseViewController<StandardTableItemViewModel>, IStandardTableItemViewController
    {
        IStandardTableItemRepository<StandardTableItemViewModel> _Reposetory;
        IStandardTableItemService<StandardTableItemViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new StandardTableItemService<StandardTableItemViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<StandardTableItemViewModel>(U, P, C, A));
            _Reposetory = new StandardTableItemRepository<StandardTableItemViewModel>(_MasterRepo, _Service);
        }

        public async Task StandardTableItem_Event()
        {
            
        }
    }
}