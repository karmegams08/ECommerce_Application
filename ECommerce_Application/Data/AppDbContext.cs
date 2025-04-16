using Microsoft.EntityFrameworkCore;

namespace ECommerce_Application.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        { 
        
        
        
        }
       
    }
}
