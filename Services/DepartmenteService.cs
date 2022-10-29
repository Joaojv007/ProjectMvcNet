using ProjectMvcNet.Data;
using System.Linq;
using ProjectMvcNet.Models;
using System.Collections.Generic;

namespace ProjectMvcNet.Services
{
    public class DepartmenteService
    {
        private readonly ProjectMvcNetContext _context;

        public DepartmenteService(ProjectMvcNetContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

/*        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }*/
    }
}
