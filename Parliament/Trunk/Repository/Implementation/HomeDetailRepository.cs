using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Root.Repository;

namespace Parliament.Implementation.Repository
{
    public class HomeDetailRepository<T> : ProjectBaseRepository, IHomeDetailRepository<T>
        where T : BaseViewModel
    {
        IHomeDetailService<T> _Service;

        public HomeDetailRepository(IMasterRepository masterRepository, IHomeDetailService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task FetchDashboard(HomeDetailViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.FetchDashboard(model);
            completeAction(serviceReturnModel);
        }
    }
}