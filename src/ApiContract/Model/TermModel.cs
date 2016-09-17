﻿using OwnApt.Common.Dto;
using System;

namespace OwnApt.Api.Contract.Model
{
    public class TermModel : Equatable
    {
        #region Public Properties

        public DateTime EndDate { get; set; }
        public string PropertyId { get; set; }
        public decimal Rent { get; set; }
        public DateTime StartDate { get; set; }
        public string TermId { get; set; }

        #endregion Public Properties
    }
}
