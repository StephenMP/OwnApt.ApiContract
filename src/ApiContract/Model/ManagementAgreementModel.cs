using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class ManagementAgreementModel : Equatable
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public List<ManagementAgreementSectionModel> Sections { get; set; }

    }

    public class ManagementAgreementSectionModel : Equatable
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
