using ProjectMvcNet.Models;
using System;
using System.Linq;

namespace ProjectMvcNet.Data
{
    public class SeedingService
    {
        private ProjectMvcNetContext _context;

        public SeedingService(ProjectMvcNetContext context)
        {
            _context = context; 
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "fashion");
            Department d4 = new Department(4, "books");

            Seller s1 = new Seller(1, "Bob Brow", "victor@gmail.com", 1000.0, new DateTime(1998, 4, 21), d1);
            Seller s2 = new Seller(2, "jv", "jv@gmail.com", 1500.0, new DateTime(1999, 4, 21), d2);
            Seller s3 = new Seller(3, "vitor", "vitor@gmail.com", 2000.0, new DateTime(1970, 4, 21), d2);
            Seller s4 = new Seller(4, "roberta", "rob@gmail.com", 3000.0, new DateTime(1999, 4, 21), d3);
            Seller s5 = new Seller(5, "julia", "julia@gmail.com", 7000.0, new DateTime(1995, 5, 22), d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(1998, 4, 21), 4000.0, Models.Enums.SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(1998, 4, 21), 6000.0, Models.Enums.SalesStatus.Canceled, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(1998, 4, 21), 3000.0, Models.Enums.SalesStatus.Pending, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(1998, 4, 21), 8000.0, Models.Enums.SalesStatus.Pending, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(1998, 4, 21), 1000.0, Models.Enums.SalesStatus.Pending, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(1998, 4, 21), 2000.0, Models.Enums.SalesStatus.Billed, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(1998, 4, 21), 9000.0, Models.Enums.SalesStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7);

            _context.SaveChanges();
        }
    }
}
