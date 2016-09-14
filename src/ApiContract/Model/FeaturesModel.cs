using OwnApt.Common.Dto;
using OwnApt.Common.Extension;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class FeaturesModel : Equatable<FeaturesModel>
    {
        #region Properties

        public IList<AmenityModel> Ammentities { get; set; }
        public double Bathrooms { get; set; }
        public int Levels { get; set; }
        public IList<ParkingModel> Parking { get; set; }
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
