using Microsoft.AspNetCore.Mvc;

namespace LogSink.Services.LogService
{
    public class LogApi : ILogApi
    {
        public ActionResult<LogResponse> Debug(string log)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult<LogResponse> Error(string log)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult<LogResponse> Fatal(string log)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult<LogResponse> Info(string log)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult<LogResponse> Trace(string log)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult<LogResponse> Warn(string log)
        {
            throw new System.NotImplementedException();
        }
    }
}