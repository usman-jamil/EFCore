using System.Data;

namespace EFCore.Playground.Domain.Abstractions;

public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
