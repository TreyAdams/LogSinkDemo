namespace LogSink.Services.LogService
{
    public class LogApi : ILogApi
    {
        public LogResponse Debug(string log)
        {
            return new LogResponse();
        }

        public LogResponse Error(string log)
        {
            return new LogResponse();
        }

        public LogResponse Fatal(string log)
        {
            return new LogResponse();
        }

        public LogResponse Info(string log)
        {
            return new LogResponse();
        }

        public LogResponse Trace(string log)
        {
            return new LogResponse();
        }

        public LogResponse Warn(string log)
        {
            return new LogResponse();
        }
    }
}