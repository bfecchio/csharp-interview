using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Interview.Recruiter.Data.Context;
using Interview.Recruiter.Domain.AggregateModel.CandidateAggregate;

namespace Interview.Recruiter.Data.Configurations
{
    internal sealed class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        #region IEntityTypeConfiguration Members

        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidates", ApplicationDbContext.SCHEMA);

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Surname).HasColumnType("VARCHAR(150)").IsRequired();
        }

        #endregion
    }
}
