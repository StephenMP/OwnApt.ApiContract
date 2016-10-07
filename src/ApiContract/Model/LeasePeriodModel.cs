using OwnApt.Common.Dto;
using OwnApt.Common.Enums;

namespace OwnApt.Api.Contract.Model
{
    public class LeasePeriodModel : Equatable
    {
        #region Public Properties

        public int LeasePeriodId { get; set; }
        public LeasePeriodStatus LeasePeriodStatus { get; set; }
        public int LeaseTermId { get; set; }
        public string Period { get; set; }

        #endregion Public Properties
    }
}
