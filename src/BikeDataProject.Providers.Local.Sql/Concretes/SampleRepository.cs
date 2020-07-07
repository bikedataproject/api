namespace BikeDataProject.Providers.Local.Sql.Concretes
{
    using BikeDataProject.Core.Models;
    using BikeDataProject.Core.SearchParameters;
    using BikeDataProject.Providers.Local.Sql.Declarations;

    /// <summary>
    /// Contains the implementation for the <see cref="SampleRepository"/>.
    /// </summary>
    /// <seealso cref="BikeDataProject.Providers.Local.Sql.Declarations.ISampleRepository" />
    public class SampleRepository : ISampleRepository
    {
        public SampleModel GetSampleModel(SampleSearchParameters searchParameters)
        {
            //TODO: filtering the sql query
            /* 
             * "clean way" to do is to have a filter engine that is basically gonna filter every type of entity by inheritance
             * but this solution takes time and we maybe won't have the time to implement it.
            */
            // per example
            if (searchParameters.ReturnSample)
            {
                // get from DB
                return new SampleModel()
                {
                    Id = 1234,
                    SampleType = Core.Enums.SampleEnum.SuperAdmin
                };
            }

            return new SampleModel();
        }
    }
}
