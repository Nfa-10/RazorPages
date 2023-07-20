using Microsoft.EntityFrameworkCore;
using RazorCRUD.Models;

namespace RazorCRUD.Data
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BookModel> MyProperty { get; set; }
    }
}
