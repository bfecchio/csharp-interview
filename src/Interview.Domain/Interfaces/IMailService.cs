namespace Interview.Domain.Interfaces
{
    public interface IMailService
    {
        void Send(string to, string from, string body);
    }
}