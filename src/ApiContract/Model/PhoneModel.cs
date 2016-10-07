using OwnApt.Common.Dto;
using OwnApt.Common.Enums;

namespace OwnApt.Api.Contract.Model
{
    public class PhoneModel : Equatable
    {
        #region Public Properties

        public int AreaCode { get; set; }
        public int CountryCode { get; set; }
        public int LineNumber { get; set; }
        public int Prefix { get; set; }
        public PhoneType Type { get; set; }

        #endregion Public Properties
    }
}
