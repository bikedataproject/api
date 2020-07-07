namespace BikeDataProject.Core.Models
{
    using BikeDataProject.Core.Constants;
    using BikeDataProject.Core.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the definition for an object of type <see cref="SampleModel"/>.
    /// </summary>
    public class SampleModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the soft version.
        /// </summary>
        /// <value>
        /// The soft version.
        /// </value>
        public string SoftVersion { get; set; } = SampleConstantsFields.SoftVersion;

        /// <summary>
        /// Gets or sets the type of the sample.
        /// </summary>
        /// <value>
        /// The type of the sample.
        /// </value>
        public SampleEnum SampleType { get; set; } = SampleEnum.None;

        /// <summary>
        /// Gets the friends.
        /// </summary>
        /// <value>
        /// The friends.
        /// </value>
        public IEnumerable<SampleModel> Friends { get; } = new List<SampleModel>();
    }
}
