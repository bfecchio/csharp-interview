using System.Threading;
using System.Threading.Tasks;

namespace Interview.Core.Data
{
    public interface IUnitOfWork
    {
        #region IUnitOfWork Members

        Task<bool> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));

        #endregion
    }
}
