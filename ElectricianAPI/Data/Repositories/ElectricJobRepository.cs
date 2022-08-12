using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ElectricJobRepository : IElectricJobRepository
    {
        private readonly DatabaseContext _context;
        public ElectricJobRepository(DatabaseContext context)
        {
            _context = context;
        }

   

        public async Task<ElectricJob> GetElectricJobAsync(int id)
        {
            var job = await _context.ElectricJobs.FindAsync(id);

            return job;
        }

        public async Task<IReadOnlyList<ElectricJob>> GetElectricJobsAsync()
        {
            var jobs = await _context.ElectricJobs.ToListAsync();

            return jobs;
        }
    }
}
