using System.Threading.Tasks;
using System.Collections.Generic;

namespace ReviewForum.Core.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
    }
}