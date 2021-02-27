using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Interview.Core.Domain;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Recruiter.Domain.Interfaces
{
    public interface ICandidateService : IDomainService
    {
        #region ICandidateService Members

        Task<Candidate> Get(Guid id);
        Task<IEnumerable<Candidate>> GetAll();
        Task<bool> Delete(Guid id);
        Task<bool> Create(string name, string surname);
        Task<bool> Update(Guid id, string name, string surname);

        #endregion
    }
}
