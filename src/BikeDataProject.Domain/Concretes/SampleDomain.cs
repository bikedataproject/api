namespace BikeDataProject.Domain.Concretes
{
    using BikeDataProject.Core.Models;
    using BikeDataProject.Core.SearchParameters;
    using BikeDataProject.Domain.Declarations;
    using BikeDataProject.Providers.Local.Sql.Declarations;
    using System;

    /// <summary>
    /// Contains the definition of the <see cref="SampleDomain"/>.
    /// </summary>
    public class SampleDomain : ISampleDomain
    {
        private readonly ISampleRepository _sampleRepository;

        public SampleDomain(ISampleRepository _sampleRepository)
        {
            this._sampleRepository = _sampleRepository;
        }

        public SampleModel GetSampleModel(SampleSearchParameters searchParameters)
        {
            //TODO: business rules

            return this._sampleRepository.GetSampleModel(searchParameters);
        }
    }
}
