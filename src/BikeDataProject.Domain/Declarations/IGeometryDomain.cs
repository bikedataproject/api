namespace BikeDataProject.Domain.Declarations
{
    using BikeDataProject.Core.Models.Geometry;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the declaration for the <see cref="IGeometryDomain"/>.
    /// </summary>
    public interface IGeometryDomain
    {

        /// <summary>
        /// Creates the geometry.
        /// </summary>
        /// <param name="geometries">The geometries.</param>
        void CreateGeometry(IEnumerable<GeometryCore> geometries);

        /// <summary>
        /// Gets the geometries.
        /// </summary>
        /// <returns>A collection of <see cref="Geometry"/>.</returns>
        IEnumerable<GeometryCore> GetGeometries();
    }
}
