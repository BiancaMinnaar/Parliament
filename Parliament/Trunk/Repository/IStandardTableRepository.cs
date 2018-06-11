using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Repository
{
    public interface IStandardTableRepository<T>
        where T : BaseViewModel
    {
        Task StandardTable_Event(StandardTableViewModel model, Action<T> completeAction);
    }
}
