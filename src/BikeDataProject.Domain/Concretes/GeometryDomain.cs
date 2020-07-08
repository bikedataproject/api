namespace BikeDataProject.Domain.Concretes
{
    using BikeDataProject.Core.Models.Geometry;
    using BikeDataProject.Domain.Declarations;
    using BikeDataProject.Providers.Local.Sql.Declarations;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the implementation for the <see cref="GeometryDomain"/>.
    /// </summary>
    /// <seealso cref="BikeDataProject.Domain.Declarations.IGeometryDomain" />
    public class GeometryDomain : IGeometryDomain
    {
        private readonly IGeometryRepository _geometryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryDomain"/> class.
        /// </summary>
        /// <param name="geometryRepository">The geometry repository.</param>
        public GeometryDomain(IGeometryRepository geometryRepository)
            => this._geometryRepository = geometryRepository;

        public void CreateGeometry(IEnumerable<GeometryCore> geometries)
        {
            // parse geometry core to PostGIS.Geometry 
            throw new NotImplementedException();
        }

        public IEnumerable<GeometryCore> GetGeometries()
        {
            var geometries = this._geometryRepository.GetGeometries();
            // parse PostGIS.Geometry to geometry core
            throw new NotImplementedException();
        }
    }
}
