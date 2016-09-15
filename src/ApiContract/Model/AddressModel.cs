using OwnApt.Common.Dto;
using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Model
{
    public class AddressModel : Equatable
    {
        #region Public Properties

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public State State { get; set; }
        public ZipModel Zip { get; set; }

        #endregion Public Properties
    }
}
