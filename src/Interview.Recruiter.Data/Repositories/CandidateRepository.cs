using Microsoft.Extensions.Logging;
using Interview.Recruiter.Data.Context;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;
using Interview.Recruiter.Domain.Repositories;

namespace Interview.Recruiter.Data.Repositories
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
