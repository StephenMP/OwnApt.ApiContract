using OwnApt.Common.Dto;
using System;

namespace OwnApt.Api.Contract.Model
{
    public class LeaseTermModel : Equatable
    {
        #region Public Properties

        public DateTime EndDate { get; set; }
        public string PropertyId { get; set; }
        public decimal Rent { get; set; }
        public DateTime StartDate { get; set; }
        public string LeaseTermId { get; set; }

        #endregion Public Properties
    }
}
