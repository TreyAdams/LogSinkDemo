using Microsoft.AspNetCore.Mvc;

namespace LogSink.Services.LogService
{
    public class LogApi : ILogApi
    {
        public ActionResult<LogResponse> Debug(string log)
        {
            return new LogResponse();
        }

        public ActionResult<LogResponse> Error(string log)
        {
            return new LogResponse();
        }

        public ActionResult<LogResponse> Fatal(string log)
        {
            return new LogResponse();
        }

        public ActionResult<LogResponse> Info(string log)
        {
            return new LogResponse();
        }

        public ActionResult<LogResponse> Trace(string log)
        {
            return new LogResponse();
        }

        public ActionResult<LogResponse> Warn(string log)
        {
            return new LogResponse();
        }
    }
}