using SalesMVC.Data;
using SalesMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVC.Services
{
    public class SellerService
    {
        private readonly ApplicationDbContext _context;
        public SellerService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
        public void Isert(Seller seller)
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
        }
    }
}
