using FirstApi.Data;
using FirstApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksDb _context;
        public BooksController(BooksDb context)
        {
            _context = context; //inyectamos el contexto de la base de datos para poder interactuar con ella en los métodos del controlador
        }

        //GET: api/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        //GET: api/books/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        //POST: api/books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync(); //aplica cambios y guarda los cambios. la integridad de la base de datos
            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        //Put: api/books/{id}
        [HttpPut("{id}")] //Actualizar
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if(id != book.Id)
            {
                return BadRequest();
            }

            var bookInDb = await _context.Books.FindAsync(id);
            if (bookInDb == null)
            {
                return NotFound();
            }

            bookInDb.Title = book.Title;
            bookInDb.Author = book.Author;
            bookInDb.isAvailable = book.isAvailable;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        //DELETE: api/books/{id}
        [HttpDelete("{id}")] //Eliminar
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }
    }
}


//EntityFramework nos permite interactuar con la base de datos utilizando objetos C# en lugar de escribir consultas SQL directamente. Esto facilita el desarrollo y mantenimiento de aplicaciones al proporcionar una capa de abstracción sobre la base de datos. Con EntityFramework, podemos realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) de manera sencilla y eficiente, lo que mejora la productividad del desarrollador y reduce la posibilidad de errores en las consultas SQL.