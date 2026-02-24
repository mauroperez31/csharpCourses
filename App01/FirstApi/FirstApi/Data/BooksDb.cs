using FirstApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Data
{
    public class BooksDb: DbContext
    {
        public BooksDb(DbContextOptions<BooksDb> options) : base(options)
        {
            
        }

        public DbSet<Book> Books => Set<Book>(); // para agregar eliminar y enlistar en la bd

    }
}
