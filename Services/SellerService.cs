using ProjectMvcNet.Data;
using ProjectMvcNet.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMvcNet.Services
{
    public class SellerService
    {
        private readonly ProjectMvcNetContext _context;

        public SellerService(ProjectMvcNetContext context)
        {
            _context = context; 
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
