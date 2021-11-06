using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;

namespace LurtisTest.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected ILog _logger;

        public override OkObjectResult Ok([ActionResultObjectValue] object value)
        {
            return base.Ok(JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        public override BadRequestObjectResult BadRequest([ActionResultObjectValue] object error)
        {
            return base.BadRequest(JsonConvert.SerializeObject(error, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }
    }
}