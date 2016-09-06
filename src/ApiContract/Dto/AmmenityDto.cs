﻿using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class AmmenityDto : Equatable<AmmenityDto>
    {
        #region Public Properties

        public string Description { get; set; }
        public AmmenityType Type { get; set; }

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
