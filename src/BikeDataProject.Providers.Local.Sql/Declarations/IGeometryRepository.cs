namespace BikeDataProject.Providers.Local.Sql.Declarations
{
    using NetTopologySuite.Geometries;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the definition for the <see cref="IGeometryRepository"/>.
    /// </summary>
    public interface IGeometryRepository
    {
        /// <summary>
        /// Creates the geometry.
        /// </summary>
        /// <param name="geometries">The geometry.</param>
        void CreateGeometry(IEnumerable<Geometry> geometries);

        /// <summary>
        /// Gets the geometries.
        /// </summary>
        /// <returns>A collection of <see cref="Geometry"/>.</returns>
        IEnumerable<Geometry> GetGeometries();
    }
}
