namespace BikeDataProject.Core.SearchParameters
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains the definition for <see cref="SampleSearchParameters"/>.
    /// </summary>
    public class SampleSearchParameters
    {
        /// <summary>
        /// Gets or sets a value indicating whether [return sample].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [return sample]; otherwise, <c>false</c>.
        /// </value>
        [DataMember(Name = "returnSample")] // DataMember alongside with Name fields permits to set the name that we will retrieve in the incoming JSON
        public Boolean ReturnSample { get; set; }
    }
}
