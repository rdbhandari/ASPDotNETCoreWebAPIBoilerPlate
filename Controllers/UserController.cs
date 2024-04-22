using ASPDotNETCoreWebApiBoilerPlate.Common;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ASPDotNETCoreWebApiBoilerPlate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpPost("v1/AddUser")]
        public async Task<ServiceResponse<long>> AddUser([FromBody] OfficeBARegInitiateReqDTO req)
        {
            
        }
    }
}
