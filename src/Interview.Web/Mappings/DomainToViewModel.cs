using AutoMapper;

using Interview.Web.Models;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Web.Mappings
{
    internal sealed class DomainToViewModel : Profile
    {
        #region Constructors

        public DomainToViewModel() : base(nameof(DomainToViewModel))
        {
            CreateMap<Candidate, CandidateViewModel>()
                .ForMember(dest => dest.CandidateId, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opts => opts.MapFrom(src => src.Surname));
        }

        #endregion
    }
}
