namespace BikeDataProject.Providers.Local.Sql.Concretes
{
    using BikeDataProject.Providers.Local.Sql.Declarations;
    using NetTopologySuite.Geometries;
    using NetTopologySuite.IO;
    using System;
    using System.Collections.Generic;

    public class GeometryRepository : IGeometryRepository
    {
        private readonly IDbContext _dbContext;

        public GeometryRepository(IDbContext dbContext)
            => this._dbContext = dbContext;

        public void CreateGeometry(IEnumerable<Geometry> geometries)
        {
            foreach (var geometry in geometries)
            {
                var geoText = geometry.AsText();
                var data = new PostGisWriter().Write(geometry);
            }
            throw new NotImplementedException();
        }

        public IEnumerable<Geometry> GetGeometries()
        {
            throw new NotImplementedException();
        }
    }
}
