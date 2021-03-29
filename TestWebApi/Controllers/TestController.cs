using System.Web.Http;

namespace TestWebApi.Controllers
{
    [RoutePrefix("/test")]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello world");
        }
    }
}
