using Microsoft.AspNetCore.Mvc;

namespace LogSink.Services.LogService
{
    public interface ILogApi
    {
        LogResponse Fatal(string log);
        LogResponse Error(string log);
        LogResponse Warn(string log);
        LogResponse Info(string log);
        LogResponse Debug(string log);
        LogResponse Trace(string log);
    }
}