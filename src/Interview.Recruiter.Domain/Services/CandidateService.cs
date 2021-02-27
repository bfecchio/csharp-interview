using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using Interview.Core.Domain;
using Interview.Recruiter.Domain.Interfaces;
using Interview.Recruiter.Domain.Repositories;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Recruiter.Domain.Services
{
    public sealed class CandidateService : DomainService, ICandidateService
    {
        #region Read-Only Fields

        private readonly ICandidateRepository _candidateRepository;

        #endregion

        #region Constructors

        public CandidateService(ILogger<CandidateService> logger
            , ICandidateRepository candidateRepository
        )
            : base(logger)
        {
            _candidateRepository = candidateRepository ?? throw new ArgumentNullException(nameof(candidateRepository));
        }

        #endregion

        #region ICandidateService Members

        public async Task<Candidate> Get(Guid id)
        {
            return await _candidateRepository.Get(id);
        }

        public async Task<IEnumerable<Candidate>> GetAll()
        {
            return await _candidateRepository.GetAll();
        }
        public async Task<bool> Create(string name, string surname)
        {
            var aggregate = new Candidate(name, surname);
            
            await _candidateRepository.Add(aggregate);
            return await _candidateRepository.UnitOfWork.CommitAsync();
        }

        public async Task<bool> Update(Guid id, string name, string surname)
        {
            var candidate = await _candidateRepository.Get(id);
            
            candidate.SetName(name);
            candidate.SetSurname(surname);

            await _candidateRepository.Update(candidate);
            return await _candidateRepository.UnitOfWork.CommitAsync();
        }

        public async Task<bool> Delete(Guid id)
        {
            var candidate = await _candidateRepository.Get(id);
            await _candidateRepository.Delete(candidate);

            return await _candidateRepository.UnitOfWork.CommitAsync();
        }

        #endregion
    }
}
