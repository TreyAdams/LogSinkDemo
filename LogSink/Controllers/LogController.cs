using Microsoft.AspNetCore.Mvc;

namespace LogSink.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogApi logApi;

        public LogController(ILogApi logApi)
        {
            this.logApi = logApi;
        }

        [HttpPost, Route("Fatal")]
        public ActionResult<LogResponse> Fatal([FromBody] string log)
        {
            return logApi.Fatal(log);
        }


        [HttpPost, Route("Error")]
        public ActionResult<LogResponse> Error([FromBody] string log)
        {
            return logApi.Error(log);
        }

        [HttpPost, Route("Warn")]
        public ActionResult<LogResponse> Warn([FromBody] string log)
        {
            return logApi.Warn(log);
        }

        [HttpPost, Route("Info")]
        public ActionResult<LogResponse> Info([FromBody] string log)
        {
            return logApi.Info(log);
        }

        [HttpPost, Route("Debug")]
        public ActionResult<LogResponse> Debug([FromBody] string log)
        {
            return logApi.Debug(log);
        }

        [HttpPost, Route("Trace")]
        public ActionResult<LogResponse> Trace([FromBody] string log)
        {
            return logApi.Trace(log);
        }
    }
}