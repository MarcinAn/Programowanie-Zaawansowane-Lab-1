using Microsoft.EntityFrameworkCore;
using Programowanie_Zaawansowane_Labolatorium_1.Models;

namespace Programowanie_Zaawansowane_Labolatorium_1.Data
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {
        }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
