using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;
using Parliament.Interface.Service;

namespace Parliament.Implementation.Service
{
        public class StandardTableService<T> : BaseService<T>, IStandardTableService<T>
            where T : BaseViewModel
        {
            public StandardTableService(Func<string, Dictionary<string, ParameterTypedValue>, BaseViewModel, BaseNetworkAccessEnum, Task<T>> networkInterface)
                :base(networkInterface)
            {
            }

        public async Task<T> StandardTable_Event(StandardTableViewModel model)
        {
            string requestURL = "/path/{Parameter}";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, ParameterTypedValue>()
            {
                //{"Parameter", model.Property},
            };
            return await _NetworkInterface(requestURL, parameters, null, httpMethod);
        }
    }
}
