namespace Interview.Recruiter.Domain.Interfaces
{
    public interface IMailService
    {
        #region IMailService Members

        void Send(string to, string from, string body);

        #endregion
    }
}