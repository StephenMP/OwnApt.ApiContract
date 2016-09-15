using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class AmenityModel : Equatable<AmenityModel>
    {
        #region Public Properties

        public string Description { get; set; }
        public string Type { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return this.Description.GetHashCodeSafe()
                       ^ this.Type.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
