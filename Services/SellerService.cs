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

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
