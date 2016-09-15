using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class MapOwnerToPropertiesDto : Equatable<MapOwnerToPropertiesDto>
    {
        #region Public Properties

        public string OwnerId { get; set; }
        public string[] PropertyIds { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return OwnerId.GetHashCodeSafe()
                ^ PropertyIds.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
