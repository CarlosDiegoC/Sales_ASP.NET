using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //APLICAR AQUI OS DBSETS.
        
        public DbSet<SalesMVC.Models.Department> Department { get; set; }
    }
}
