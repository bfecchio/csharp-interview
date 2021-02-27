using AutoMapper;

using Interview.Web.Models;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Web.Mappings
{
    internal sealed class ViewModelToDomain : Profile
    {
        #region Constructors

        public ViewModelToDomain()
            : base(nameof(ViewModelToDomain))
        {
            CreateMap<CandidateViewModel, Candidate>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.CandidateId))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Surname, opts => opts.MapFrom(src => src.Surname));
        }

        #endregion
    }
}
