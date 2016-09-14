using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class AmenityModel : Equatable<AmenityModel>
    {
        #region Properties

        public string Description { get; set; }
        public string Type { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Description.GetHashCodeSafe()
                       ^ this.Type.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
