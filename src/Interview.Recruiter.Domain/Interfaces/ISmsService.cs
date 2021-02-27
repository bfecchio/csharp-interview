namespace Interview.Recruiter.Domain.Interfaces
{
    public interface ISmsService
    {
        #region ISmsService Members

        void Send(string phone, string message);

        #endregion
    }
}