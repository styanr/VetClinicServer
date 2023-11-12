using VetClinicServer.DTOs;

namespace VetClinicServer.Services
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T item);
        Task<T> UpdateAsync(T item);
        Task RemoveAsync(int id);
    }
}
