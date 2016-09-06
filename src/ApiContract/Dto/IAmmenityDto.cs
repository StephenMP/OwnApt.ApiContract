using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Dto
{
    public interface IAmmenityDto
    {
        #region Public Properties

        string Description { get; }
        AmmenityType Type { get; }

        #endregion Public Properties
    }
}
