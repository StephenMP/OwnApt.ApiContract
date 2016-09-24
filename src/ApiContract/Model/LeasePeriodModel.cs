using OwnApt.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwnApt.Api.Contract.Model
{
    public class LeasePeriodModel
    {
        public int LeasePeriodId { get; set; }
        public int LeaseTermId { get; set; }
        public LeasePeriodStatus LeasePeriodStatus { get; set; }
        public string PeriodId { get; set; }
    }
}
