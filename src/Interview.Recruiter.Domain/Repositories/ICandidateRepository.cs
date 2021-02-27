using Interview.Core.Data;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Recruiter.Domain.Repositories
{
    public interface ICandidateRepository : IReadRepository<Candidate>, IWriteRepository<Candidate>
    {
        #region ICandidateRepository Members

        #endregion
    }
}
