using Microsoft.AspNetCore.Mvc;

namespace to_do_list.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        [HttpGet(Name = "GetUsers")]
        public string Get()
        {
            return "w";
        }
    }
}
