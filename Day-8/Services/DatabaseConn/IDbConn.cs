namespace Day_8.Services.DatabaseConn
{
    public interface IDbConn
    {
        bool Open();
        bool Close();   
    }
}
