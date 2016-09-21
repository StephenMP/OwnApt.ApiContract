using OwnApt.Common.Dto;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class FeaturesModel : Equatable
    {
        #region Public Properties

        public List<AmenityModel> Amenities { get; set; }
        public double Bathrooms { get; set; }
        public int Levels { get; set; }
        public List<ParkingModel> Parking { get; set; }
        public int Rooms { get; set; }
        public int SqFootage { get; set; }

        #endregion Public Properties
    }
}
