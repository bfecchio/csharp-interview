using Interview.Core.Domain;
using System.Collections.Generic;

namespace Interview.Recruiter.Domain.AggregateModel.CandidateAggregate
{
    public sealed class Candidate : Entity, IAggregateRoot
    {
        #region Properties

        public string Name { get; private set; }
        public string Surname { get; private set; }

        #endregion

        #region Constructors

        public Candidate(string name, string surname)
        {
            Guard.AssertArgumentNotEmpty(name, "The name is required.");
            Guard.AssertArgumentNotEmpty(surname, "The surname is required.");

            Name = name;
            Surname = surname;
        }

        #endregion

        #region Entity Members

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }

        #endregion

        #region Methods

        public void SetName(string name)
        {
            Guard.AssertArgumentNotEmpty(name, "The name is required.");
            Name = name;
        }

        public void SetSurname(string surname)
        {
            Guard.AssertArgumentNotEmpty(surname, "The surname is required.");
            Surname = surname;
        }

        #endregion
    }
}
