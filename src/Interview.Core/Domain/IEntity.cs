using System;

namespace Interview.Core.Domain
{
    public interface IEntity : IDomainEntity
    {
        #region IEntity Members

        Guid Id { get; set; }

        #endregion
    }
}
