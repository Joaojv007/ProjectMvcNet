using ProjectMvcNet.Data;
using System.Linq;
using ProjectMvcNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectMvcNet.Services
{
    public class DepartmenteService
    {
        private readonly ProjectMvcNetContext _context;

        public DepartmenteService(ProjectMvcNetContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
