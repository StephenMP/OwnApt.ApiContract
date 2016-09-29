using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using System.ComponentModel.DataAnnotations;

namespace OwnApt.Api.Contract.Model
{
    public class AddressModel : Equatable
    {
        #region Public Constructors

        public AddressModel()
        {
            this.Zip = new ZipModel();
        }

        #endregion Public Constructors

        #region Public Properties

        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string County { get; set; }

        [Required]
        public State? State { get; set; }

        [Required]
        public ZipModel Zip { get; set; }

        #endregion Public Properties
    }
}
