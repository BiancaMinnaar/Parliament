using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Root.Repository;

namespace Parliament.Implementation.Repository
{
    public class DashboardRepository<T> : ProjectBaseRepository, IDashboardRepository<T>
        where T : BaseViewModel
    {
        IDashboardService<T> _Service;

        public DashboardRepository(IMasterRepository masterRepository, IDashboardService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Load(DashboardViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.Load(model);
            completeAction(serviceReturnModel);
        }
    }
}