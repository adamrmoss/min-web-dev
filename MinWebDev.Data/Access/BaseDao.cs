using Microsoft.EntityFrameworkCore;

namespace MinWebDev.Data;

public abstract class BaseDao
{
    private readonly MinWebDevDbContext dbContext;

    protected BaseDao(MinWebDevDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    protected int Sql(string sql, params object[] queryParameters)
    {
        var rowsAffectedCount = this.dbContext.Database
            .ExecuteSqlRaw(sql, queryParameters);

        return rowsAffectedCount;
    }

    protected TEntity[] SqlQuery<TEntity>(string sql, params object[] queryParameters)
        where TEntity : class
    {
        return this.dbContext.Set<TEntity>()
            .FromSqlRaw(sql, queryParameters)
            .AsNoTracking()
            .ToArray();
    }
}
