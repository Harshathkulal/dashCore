using Microsoft.EntityFrameworkCore;
using SimpleDashboardApi.Models;

namespace SimpleDashboardApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<DashboardItem> DashboardItems { get; set; }
    }
}
