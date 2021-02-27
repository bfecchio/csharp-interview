using System.Threading.Tasks;

using Interview.Core.Domain;

namespace Interview.Core.Data
{
    public interface IWriteRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        #region IReadRepository Members

        Task Add(TAggregateRoot aggregateRoot);
        Task Update(TAggregateRoot aggregateRoot);
        Task Delete(TAggregateRoot aggregateRoot);

        #endregion
    }
}
