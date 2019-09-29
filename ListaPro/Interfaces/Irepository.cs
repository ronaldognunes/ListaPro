using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListaPro.Interfaces
{
    public interface Irepository<T> where T : class 
    {
        Task<T> GetById();
        Task<IEnumerable<T>> GetAll();
        Task Remove(int id);
        Task Add(T obj);
        Task Update(T obj);
    }
}