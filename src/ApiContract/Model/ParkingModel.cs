using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class ParkingModel : Equatable<ParkingModel>
    {
        #region Properties

        public string Description { get; set; }
        public string Type { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Type.GetHashCodeSafe()
                ^ this.Description.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
