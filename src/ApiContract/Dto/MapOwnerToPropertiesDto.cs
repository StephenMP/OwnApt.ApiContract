using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class MapOwnerToPropertiesDto : Equatable<MapOwnerToPropertiesDto>
    {
        #region Properties

        public string OwnerId { get; set; }
        public string[] PropertyIds { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return OwnerId.GetHashCodeSafe()
                ^ PropertyIds.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
