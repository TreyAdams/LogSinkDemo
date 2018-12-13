using Microsoft.AspNetCore.Mvc;

namespace LogSink.Controllers
{
    public interface ILogApi
    {
        ActionResult<LogResponse> Fatal(string log);
        ActionResult<LogResponse> Error(string log);
        ActionResult<LogResponse> Warn(string log);
        ActionResult<LogResponse> Info(string log);
        ActionResult<LogResponse> Debug(string log);
        ActionResult<LogResponse> Trace(string log);
    }
}