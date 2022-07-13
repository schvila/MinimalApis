using Dapper;
using Library.Api.Data;
using Library.Api.Models;

namespace Library.Api.Services;

class BookService : IBookService
{
    private readonly IDbConnectionFactory _connectionFactory;

    public BookService(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<bool> CreateAsync(Book book)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(
            @"INSERT INTO Books(Isbn, Title, Author, ShortDescription, PageCount,  ReleaseDate)
            VALUES(@Isbn, @Title, @Author, @ShortDescription, @PageCount,  @ReleaseDate)",
            book);
        return result > 0;
    }

    public Task<Book?> GetByIsbnAsync(string isbn)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Book>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(string isbn)
    {
        throw new NotImplementedException();
    }
}