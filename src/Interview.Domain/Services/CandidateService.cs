using System;
using Microsoft.Extensions.Logging;

using Interview.Core.Domain;
using Interview.Domain.Interfaces;
using Interview.Domain.Repositories;

namespace Interview.Domain.Services
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
    }
}
