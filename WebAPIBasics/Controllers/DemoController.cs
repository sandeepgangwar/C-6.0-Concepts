using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIBasics.Controllers
{
    public class DemoController : ApiController
    {
        private List<string> data = new List<string>
        {
            "1",
            "2",
            "3"
        };

        public IEnumerable<string> Get()
        {

            return data;
        }

        public HttpResponseMessage Get(int id)
        {
            if (id < data.Count)
            {
                return Request.CreateResponse(HttpStatusCode.Found, data[id]);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Item Not found");
            }
        }

        public HttpResponseMessage Post([FromBody]string value)
        {
            data.Add(value);
            var msg = Request.CreateResponse(HttpStatusCode.Created);
            msg.Headers.Location = new System.Uri(Request.RequestUri.AbsoluteUri + data.Count.ToString());
            return msg;
        }
    }
}