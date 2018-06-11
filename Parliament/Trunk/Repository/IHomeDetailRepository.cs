using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Repository
{
    public interface IHomeDetailRepository<T>
        where T : BaseViewModel
    {
        Task FetchDashboard(HomeDetailViewModel model, Action<T> completeAction);
    }
}
