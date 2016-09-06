using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Dto
{
    public interface IParkingDto
    {
        #region Public Properties

        string Description { get; }
        ParkingType Type { get; }

        #endregion Public Properties
    }
}
