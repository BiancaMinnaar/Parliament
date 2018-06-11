using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Service
{
    public interface IStandardTableItemService<T>
        where T : BaseViewModel
    {
        Task<T> StandardTableItem_Event(StandardTableItemViewModel model);
    }
}

