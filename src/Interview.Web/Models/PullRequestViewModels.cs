using Interview.Web.Interfaces;

namespace Interview.Web.Models
{
    public sealed class PullRequestViewModel : IViewModel
    {
        #region Properties

        public string Field1 { get; set; }
        public string Field2 { get; set; }

        #endregion
    }
}
