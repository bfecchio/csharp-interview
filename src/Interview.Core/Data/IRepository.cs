using System;

using Interview.Core.Domain;

namespace Interview.Core.Data
{
    public interface IRepository<TAggregateRoot> : IDisposable
        where TAggregateRoot : IAggregateRoot
    {
        #region IRepository Members

        IUnitOfWork UnitOfWork { get; }

        #endregion
    }
}
