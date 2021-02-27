using Interview.Recruiter.Domain.Interfaces;

namespace Interview.Recruiter.Domain.Services
{
    public sealed class SmsService : ISmsService
    {
        #region ISmsService Members

        public void Send(string phone, string message)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}