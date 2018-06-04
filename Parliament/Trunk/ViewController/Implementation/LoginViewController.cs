using System.Threading.Tasks;
using Parliament.Implementation.Repository;
using Parliament.Implementation.Service;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Repository;
using Parliament.Interface.Service;
using Parliament.Interface.ViewController;
using Parliament.Root.ViewController;

namespace Parliament.Implementation.ViewController
{
    public class LoginViewController : ProjectBaseViewController<LoginViewModel>, ILoginViewController
    {
        ILoginRepository<LoginViewModel> _Reposetory;
        ILoginService<LoginViewModel> _Service;

        public override void SetRepositories()
        {
            _Service = new LoginService<LoginViewModel>((U, P, C, A) => 
                                                           ExecuteQueryWithReturnTypeAndNetworkAccessAsync<LoginViewModel>(U, P, C, A));
            _Reposetory = new LoginRepository<LoginViewModel>(_MasterRepo, _Service);
        }

        public async Task Login()
        {
            await _Reposetory.Login(InputObject, (LoginViewModel obj) => 
            { 
                //ShowMessage(_ResponseContent); 
            });
        }
    }
}