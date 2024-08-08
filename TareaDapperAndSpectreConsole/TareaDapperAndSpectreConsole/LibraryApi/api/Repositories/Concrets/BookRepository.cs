using Dapper;
using MySql.Data.MySqlClient;
using LibraryApi.api.Entities;
using LibraryApi.api.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace LibraryApi.api.Repositories.Concrets;

public class BookRepository : IBookRepository
{
    private readonly string _connectionString;

    public BookRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    private MySqlConnection CreateConnection()
    {
        return new MySqlConnection(_connectionString);
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        using (var connection = CreateConnection())
        {
            return await connection.QueryAsync<Book>("SELECT * FROM Books");
        }
    }

    public async Task<Book> GetBookByIdAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            return await connection.QueryFirstOrDefaultAsync<Book>("SELECT * FROM Books WHERE Id = @Id", new { Id = id });
        }
    }

    public async Task AddBookAsync(Book book)
    {
        using (var connection = CreateConnection())
        {
            await connection.ExecuteAsync("INSERT INTO Books (Title, Author, Year) VALUES (@Title, @Author, @Year)", book);
        }
    }

    public async Task UpdateBookAsync(Book book)
    {
        using (var connection = CreateConnection())
        {
            await connection.ExecuteAsync("UPDATE Books SET Title = @Title, Author = @Author, Year = @Year WHERE Id = @Id", book);
        }
    }

    public async Task DeleteBookAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            await connection.ExecuteAsync("DELETE FROM Books WHERE Id = @Id", new { Id = id });
        }
    }
}
