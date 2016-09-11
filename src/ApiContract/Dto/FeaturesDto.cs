using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class FeaturesDto : Equatable<FeaturesDto>
    {
        #region Properties

        public AmmenityDto[] Ammentities { get; set; }
        public double Bathrooms { get; set; }
        public int Levels { get; set; }
        public ParkingDto Parking { get; set; }
        public int Rooms { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Rooms.GetHashCodeSafe()
                ^ this.Bathrooms.GetHashCodeSafe()
                ^ this.Ammentities.GetHashCodeSafe()
                ^ this.Levels.GetHashCodeSafe()
                ^ this.Parking.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
