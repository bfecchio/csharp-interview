using Interview.Recruiter.Domain.Interfaces;

namespace Interview.Recruiter.Domain.Services
{
    public sealed class MailService : IMailService
    {
        #region IMailService Members

        public void Send(string to, string from, string body)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}