using BooksMadeIntoMovies_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksMadeIntoMovies_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public BookController(AppDbContext dbContext)     //Dependency Injection
        {
            _dbContext = dbContext;
        }

        [HttpGet("all")]
        public async Task<IActionResult> AllBooks()      //Asynkron metod för att hämta alla böcker från databasen
        {
            try
            {
                var books = await _dbContext.Books.ToListAsync();

                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var book = await _dbContext.Books.FindAsync(id);

                if (book == null)
                    return NotFound();  //Felhantering: Ifall boken med id inte finns

                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
