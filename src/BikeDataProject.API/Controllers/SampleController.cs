namespace BikeDataProject.API.Controllers
{
    using BikeDataProject.API.Controllers.Security;
    using BikeDataProject.API.SearchParameters;
    using BikeDataProject.Core.Models;
    using Microsoft.AspNetCore.Mvc;
    using System;

    /// <summary>
    /// Contains the definition for the <see cref="SampleController"/>.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : SecurityController 
    {
        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <returns>200 alongside with a sample model.</returns>
        [Route("[action]/")]
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
        [Route("[action]/")]
        [HttpPost]
        public IActionResult GetSampleModel(SampleSearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }
    }
}
