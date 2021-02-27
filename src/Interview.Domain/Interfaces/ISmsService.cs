namespace Interview.Domain.Interfaces
{
    public interface ISmsService
    {
        void Send(string phone, string message);
    }
}