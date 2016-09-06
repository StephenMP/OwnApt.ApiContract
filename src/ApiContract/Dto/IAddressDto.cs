using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Dto
{
    public interface IAddressDto
    {
        #region Public Properties

        string Address1 { get; }
        string Address2 { get; }
        string City { get; }
        string County { get; }
        State State { get; }
        IZipDto Zip { get; }

        #endregion Public Properties
    }
}
