using System.Threading.Tasks;
using CorePCL;
using Parliament.Implementation.ViewModel;

namespace Parliament.Interface.Service
{
    public interface IStandardTableService<T>
        where T : BaseViewModel
    {
        Task<T> StandardTable_Event(StandardTableViewModel model);
    }
}

