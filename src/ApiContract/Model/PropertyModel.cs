﻿using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using System;

namespace OwnApt.Api.Contract.Model
{
    public class PropertyModel : Equatable
    {
        #region Public Constructors

        public PropertyModel()
        {
            this.Address = new AddressModel();
            this.Features = new FeaturesModel();
        }

        #endregion Public Constructors

        #region Public Properties

        public AddressModel Address { get; set; }
        public FeaturesModel Features { get; set; }
        public string Id { get; set; }
        public Uri ImageUri { get; set; }
        public PropertyType PropertyType { get; set; }

        #endregion Public Properties
    }
}
