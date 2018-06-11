using System;
using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Repository
{
    public interface IStandardTableItemRepository<T>
        where T : BaseViewModel
    {
        Task StandardTableItem_Event(StandardTableItemViewModel model, Action<T> completeAction);
    }
}
