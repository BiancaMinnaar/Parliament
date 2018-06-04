using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Service
{
    public interface ILoginService<T>
        where T : BaseViewModel
    {
        Task<T> Login(LoginViewModel model);
    }
}

