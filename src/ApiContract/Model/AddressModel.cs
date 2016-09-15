using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class AddressModel : Equatable<AddressModel>
    {
        #region Public Properties

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public State State { get; set; }
        public ZipModel Zip { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return this.Address1.GetHashCodeSafe()
                       ^ this.Address2.GetHashCodeSafe()
                       ^ this.City.GetHashCodeSafe()
                       ^ this.County.GetHashCodeSafe()
                       ^ this.State.GetHashCodeSafe()
                       ^ this.Zip.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
