namespace BikeDataProject.Domain.Declarations
{
    using BikeDataProject.Core.Models;
    using BikeDataProject.Core.SearchParameters;
    using System;

    /// <summary>
    /// Contains the definition for the <see cref="ISampleDomain"/>.
    /// </summary>
    public interface ISampleDomain
    {
        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <returns>Returns a sample model based on search parameters.</returns>
        SampleModel GetSampleModel(SampleSearchParameters searchParameters);
    }
}
