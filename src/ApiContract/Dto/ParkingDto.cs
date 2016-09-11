﻿using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class ParkingDto : Equatable<ParkingDto>
    {
        #region Properties

        public string Description { get; set; }
        public ParkingType Type { get; set; }

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
