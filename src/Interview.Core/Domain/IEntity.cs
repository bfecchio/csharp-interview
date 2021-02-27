using System;

namespace Interview.Core.Domain
{
    public interface IEntity
    {
        #region IEntity Members

        Guid Id { get; set; }

        #endregion
    }
}
