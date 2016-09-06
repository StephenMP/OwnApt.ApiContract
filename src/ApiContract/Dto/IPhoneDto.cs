using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Dto
{
    public interface IPhoneDto
    {
        #region Public Properties

        int AreaCode { get; }
        int CountryCode { get; }
        int LineNumber { get; }
        int Prefix { get; }
        PhoneType Type { get; }

        #endregion Public Properties
    }
}
