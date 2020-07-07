namespace BikeDataProject.Providers.Local.Sql.Declarations
{
    using BikeDataProject.Core.Models;
    using BikeDataProject.Core.SearchParameters;

    /// <summary>
    /// Contains the declaration of the <see cref="ISampleRepository"/>.
    /// </summary>
    public interface ISampleRepository
    {
        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <returns>A sample model that corresponds to search parameters.</returns>
        SampleModel GetSampleModel(SampleSearchParameters searchParameters);
    }
}
