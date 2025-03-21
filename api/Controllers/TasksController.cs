using Microsoft.AspNetCore.Mvc;

namespace to_do_list.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet(Name = "GetTasks")]
        public string Get()
        {
            return "re";
        }
    }
}
