using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Root.Repository;

namespace Parliament.Implementation.Repository
{
    public class StandardTableRepository<T> : ProjectBaseRepository, IStandardTableRepository<T>
        where T : BaseViewModel
    {
        IStandardTableService<T> _Service;

        public StandardTableRepository(IMasterRepository masterRepository, IStandardTableService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task StandardTable_Event(StandardTableViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.StandardTable_Event(model);
            completeAction(serviceReturnModel);
        }
    }
}