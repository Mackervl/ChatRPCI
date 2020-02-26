using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatRPCI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
       
        public DbSet<CHsModel> Chs { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

            
            Database.EnsureCreated();
        }
    }
}
