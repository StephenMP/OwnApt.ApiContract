using OwnApt.Common.Dto;
using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Model
{
    public class BirthdateModel : Equatable
    {
        #region Public Properties

        public int Day { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }

        #endregion Public Properties
    }
}
