﻿using OwnApt.Common.Dto;
using System;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class LeaseTermModel : Equatable
    {
        #region Public Properties

        public DateTime EndDate { get; set; }
        public int LeaseTermId { get; set; }
        public string PropertyId { get; set; }
        public decimal Rent { get; set; }
        public DateTime StartDate { get; set; }
        public bool Active { get; set; }
        public List<LeasePeriodModel> LeasePeriods { get; set; }

        #endregion Public Properties
    }
}
