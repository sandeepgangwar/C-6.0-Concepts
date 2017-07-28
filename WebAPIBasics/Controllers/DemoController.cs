using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIBasics.Controllers
{
    public class DemoController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "Hello", "World" };
        }
    }
}