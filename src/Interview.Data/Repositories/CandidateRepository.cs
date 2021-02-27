using Microsoft.Extensions.Logging;

using Interview.Data.Context;
using Interview.Domain.Repositories;
using Interview.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Data.Repositories
{
    public sealed class CandidateRepository : Repository<Candidate>, ICandidateRepository
    {
        #region Constructors

        public CandidateRepository(ApplicationDbContext context, ILogger<CandidateRepository> logger)
            : base(context, logger)
        { }

        #endregion
    }
}
