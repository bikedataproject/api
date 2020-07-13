namespace BikeDataProject.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains the definition for the <see cref="SampleController"/>.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    public class SampleController 
    {
        public SampleController()
        {
        }

        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <returns>200 alongside with a sample model.</returns>
        [HttpGet]
        public IActionResult GetNewSampleModel()
        {            
            return null;
        }

        /// <summary>
        /// Gets the sample model.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        /// <returns>A sample model based on search parameters.</returns>
        [HttpPost]
        public IActionResult GetSampleModel()
        {
            return null;
        }
    }
}
