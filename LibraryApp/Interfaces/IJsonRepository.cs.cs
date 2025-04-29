using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryApp.Repositories
{
    public interface IJsonRepository
    {
        Task SaveDataAsync<T>(T data);
        Task<List<T>> LoadDataAsync<T>();
    }
}
