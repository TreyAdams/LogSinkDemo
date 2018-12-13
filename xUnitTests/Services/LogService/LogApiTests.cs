using LogSink.Services.LogService;
using System;
using Xunit;

namespace xUnitTests.Services.LogService
{
    public class LogApiTests
    {
        [Fact]
        public void Debug()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Debug(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void Error()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Error(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void Fatal()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Fatal(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void Info()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Info(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void Trace()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Trace(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void Warn()
        {
            //Arrange
            ILogApi logApi = new LogApi();

            //Act
            var response = logApi.Warn(Guid.NewGuid().ToString());

            //Assert
            Assert.NotNull(response);
        }
    }
}
