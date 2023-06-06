using Day_8.Services.DatabaseConn;

namespace Day_8.Services.Logger
{
    public class LoggerCustom : ILoggerCustom
    {
        private string _log;
        private bool _disposed;
        private readonly IDbConn _dbConn;
        public LoggerCustom(IDbConn dbConn)
        {
            _dbConn= dbConn;
        }
        public void Log(string logMessage)
        {
            _disposed = _dbConn.Close();
            _log = "Lg attım kanka";
        }
    }
}
