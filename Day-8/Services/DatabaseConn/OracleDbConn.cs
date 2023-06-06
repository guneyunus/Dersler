namespace Day_8.Services.DatabaseConn
{
    public class OracleDbConn : IDbConn
    {
        public bool Close()
        {
            return false;
        }

        public bool Open()
        {
            return true;
        }
    }
}
