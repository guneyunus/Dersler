namespace Day_8.Services.DatabaseConn
{
    public class DbConn : IDbConn
    {
        public bool Close()
        {
            return true;
        }

        public bool Open()
        {
            return false;
        }
    }
}
