using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Service
{
    public interface IHomeDetailService<T>
        where T : BaseViewModel
    {
        Task<T> FetchDashboard(HomeDetailViewModel model);
    }
}

