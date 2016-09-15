using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Dto
{
    public class MapOwnerToPropertiesDto : Equatable
    {
        #region Public Properties

        public string OwnerId { get; set; }
        public string[] PropertyIds { get; set; }

        #endregion Public Properties
    }
}
