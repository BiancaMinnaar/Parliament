using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Repository
{
    public interface ILoginRepository<T>
        where T : BaseViewModel
    {
        Task Login(LoginViewModel model, Action<T> completeAction);
    }
}
