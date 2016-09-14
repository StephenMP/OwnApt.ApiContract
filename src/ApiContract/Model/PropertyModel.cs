using OwnApt.Api.Contract.Dto;
using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class PropertyModel : Equatable<PropertyModel>
    {
        #region Properties

        public AddressModel Address { get; set; }
        public FeaturesModel Features { get; set; }
        public string Id { get; set; }
        public IList<string> OwnerIds { get; set; }
        public PropertyType PropertyType { get; set; }
        public IList<string> TenantIds { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Id.GetHashCodeSafe()
                ^ this.Address.GetHashCodeSafe()
                ^ this.OwnerIds.GetHashCodeSafe()
                ^ this.TenantIds.GetHashCodeSafe()
                ^ this.Features.GetHashCodeSafe()
                ^ this.PropertyType.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
