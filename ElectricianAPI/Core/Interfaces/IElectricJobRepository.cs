using Core.Entities;

namespace Core.Interfaces
{
    public interface IElectricJobRepository
    {
        Task<ElectricJob> GetElectricJobAsync(int id);
        Task<IReadOnlyList<ElectricJob>> GetElectricJobsAsync();  
    }
}
