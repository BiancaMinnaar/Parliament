using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Service;

namespace Parliament.Implementation.Service
{
        public class LoginService<T> : BaseService<T>, ILoginService<T>
            where T : BaseViewModel
        {
            public LoginService(Func<string, Dictionary<string, ParameterTypedValue>, BaseViewModel, BaseNetworkAccessEnum, Task<T>> networkInterface)
                :base(networkInterface)
            {
            }

        public async Task<T> Login(LoginViewModel model)
        {
            string requestURL = "/login";
            var httpMethod = BaseNetworkAccessEnum.Post;
            var parameters = new Dictionary<string, ParameterTypedValue>()
            {
                {"password", new ParameterTypedValue(WebUtility.UrlEncode(model.Password))},
            };
            return await _NetworkInterface(requestURL, parameters, null, httpMethod);
        }
    }
}
