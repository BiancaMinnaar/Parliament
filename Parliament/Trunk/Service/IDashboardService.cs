using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Service
{
    public interface IDashboardService<T>
        where T : BaseViewModel
    {
        Task<T> Load(DashboardViewModel model);
    }
}

