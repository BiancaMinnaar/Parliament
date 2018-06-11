using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Root.Repository;

namespace Parliament.Implementation.Repository
{
    public class StandardTableItemRepository<T> : ProjectBaseRepository, IStandardTableItemRepository<T>
        where T : BaseViewModel
    {
        IStandardTableItemService<T> _Service;

        public StandardTableItemRepository(IMasterRepository masterRepository, IStandardTableItemService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task StandardTableItem_Event(StandardTableItemViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.StandardTableItem_Event(model);
            completeAction(serviceReturnModel);
        }
    }
}