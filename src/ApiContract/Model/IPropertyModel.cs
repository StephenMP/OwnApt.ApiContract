using OwnApt.Api.Contract.Dto;
using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Model
{
    public interface IPropertyModel
    {
        #region Public Properties

        IAddressDto Address { get; }
        IFeaturesDto Features { get; }
        string Id { get; }
        string[] OwnerIds { get; }
        PropertyType PropertyType { get; }
        string[] TenantIds { get; }

        #endregion Public Properties
    }
}
