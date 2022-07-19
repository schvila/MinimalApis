using System.Data;

namespace Extended.Api.Data;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}
