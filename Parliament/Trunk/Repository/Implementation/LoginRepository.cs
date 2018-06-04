using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Root.Repository;

namespace Parliament.Implementation.Repository
{
    public class LoginRepository<T> : ProjectBaseRepository, ILoginRepository<T>
        where T : BaseViewModel
    {
        ILoginService<T> _Service;

        public LoginRepository(IMasterRepository masterRepository, ILoginService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }

        public async Task Login(LoginViewModel model, Action<T> completeAction)
        {
            var serviceReturnModel = await _Service.Login(model);
            completeAction(serviceReturnModel);
        }
    }
}