using Microsoft.EntityFrameworkCore;
using Programowanie_Zaawansowane_Labolatorium_1.Models;

namespace Programowanie_Zaawansowane_Labolatorium_1.Data
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
    }
}
