using ExtremeDemo.Pages.Models;
using Microsoft.EntityFrameworkCore;

namespace ExtremeDemo.Data
{
    public class DashboardContext:DbContext
    {
           public DashboardContext(DbContextOptions<DashboardContext> options)
            : base(options)
        {
        }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<PeriodicPlanCostumer> PeriodicPlanList { get; set; }
    }
}