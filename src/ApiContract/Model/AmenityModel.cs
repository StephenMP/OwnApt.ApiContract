using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class AmenityModel : Equatable
    {
        #region Public Properties

        public string Description { get; set; }
        public string Type { get; set; }

        #endregion Public Properties
    }
}
