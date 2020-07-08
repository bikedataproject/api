namespace BikeDataProject.API.Controllers.Security
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Contains the definition for <see cref="SecurityController"/>.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        // Basically this controller will serve to everything related to security, from certificate verification (if needed) to global exception handling.
        // Every controller will herit this one to provide a secure API and without having to re-override security methods :)
    }
}
