using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class PropertyModel : Equatable
    {
        #region Public Properties

        public AddressModel Address { get; set; }
        public FeaturesModel Features { get; set; }
        public string Id { get; set; }
        public IList<string> OwnerIds { get; set; }
        public PropertyType PropertyType { get; set; }
        public IList<string> TenantIds { get; set; }

        #endregion Public Properties
    }
}
