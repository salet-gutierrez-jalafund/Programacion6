using LibraryApi.api.Entities;
using LibraryApi.api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookRepository _bookRepository;

    public BooksController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
    {
        var books = await _bookRepository.GetAllBooksAsync();
        return Ok(books);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBookById(int id)
    {
        var book = await _bookRepository.GetBookByIdAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        return Ok(book);
    }

    [HttpPost]
    public async Task<ActionResult> AddBook([FromBody] Book book)
    {
        if (book == null)
        {
            return BadRequest("Book is null.");
        }

        await _bookRepository.AddBookAsync(book);
        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateBook(int id, [FromBody] Book book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }
        await _bookRepository.UpdateBookAsync(book);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteBook(int id)
    {
        await _bookRepository.DeleteBookAsync(id);
        return NoContent();
    }
}
