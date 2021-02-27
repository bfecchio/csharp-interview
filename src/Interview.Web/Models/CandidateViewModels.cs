using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Interview.Web.Interfaces;

namespace Interview.Web.Models
{
    public sealed class CandidateViewModel : IViewModel
    {
        #region Properties

        public Guid CandidateId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Surname { get; set; }

        public IEnumerable<CandidateViewModel> Candidates { get; set; } = new List<CandidateViewModel>();

        #endregion
    }
}
