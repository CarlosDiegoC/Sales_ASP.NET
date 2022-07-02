using SalesMVC.Data;
using SalesMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesMVC.Services
{
    public class DepartmentService
    {
        private readonly ApplicationDbContext _context;
        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Departments.OrderBy(dp => dp.Name).ToList();
        }
    }
}
