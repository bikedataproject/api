namespace BikeDataProject.API.Controllers
{
    using BikeDataProject.API.Controllers.Security;
    using BikeDataProject.Core.Models;
    using BikeDataProject.Core.SearchParameters;
    using BikeDataProject.Domain.Declarations;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains the definition for the <see cref="SampleController"/>.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    public class SampleController : SecurityController 
    {
        /// <summary>
        /// The sample domain.
        /// </summary>
        private readonly ISampleDomain _sampleDomain;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleController"/> class.
        /// </summary>
        /// <param name="_sampleDomain">The sample domain.</param>
        public SampleController(ISampleDomain _sampleDomain)
        {
            this._sampleDomain = _sampleDomain;
        }

        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <returns>200 alongside with a sample model.</returns>
        [HttpGet]
        public IActionResult GetNewSampleModel()
        {
            return this.Ok(new SampleModel());
        }

        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <returns>A sample model based on search parameters.</returns>
        [HttpPost]
        public IActionResult GetSampleModel(SampleSearchParameters searchParameters)
        {
            return this.Ok(this._sampleDomain.GetSampleModel(searchParameters));
        }
    }
}
