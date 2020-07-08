namespace BikeDataProject.Providers.Local.Sql.Declarations
{
    using Npgsql;

    /// <summary>
    /// Contains the definition for the <see cref="IDbContext"/>.
    /// </summary>
    public interface IDbContext
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>Returns a new postgresql connection.</returns>
        NpgsqlConnection GetConnection();
    }
}
