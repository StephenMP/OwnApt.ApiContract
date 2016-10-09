using System.ComponentModel.DataAnnotations;
using OwnApt.Common.Dto;
using OwnApt.Common.Enums;

namespace OwnApt.Api.Contract.Model
{
    public class AddressModel : Equatable
    {
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
