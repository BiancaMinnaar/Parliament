using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Repository
{
    public interface IDashboardRepository<T>
        where T : BaseViewModel
    {
        Task Load(DashboardViewModel model, Action<T> completeAction);
    }
}
