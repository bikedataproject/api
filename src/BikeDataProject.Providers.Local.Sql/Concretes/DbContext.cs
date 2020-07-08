namespace BikeDataProject.Providers.Local.Sql.Concretes
{
    using BikeDataProject.Providers.Local.Sql.Declarations;
    using Npgsql;

    /// <summary>
    /// Contains the database context.
    /// </summary>
    public class DbContext : IDbContext
	{
		private readonly string _connectionString;

		public DbContext(string connectionString)
			=> this._connectionString = connectionString;

		public NpgsqlConnection GetConnection() => new NpgsqlConnection(_connectionString);
	}
}
