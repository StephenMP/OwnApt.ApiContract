using OwnApt.Common.Dto;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class ContactModel : Equatable
    {
        #region Public Properties

        public string Email { get; set; }
        public AddressModel HomeAddress { get; set; }
        public List<PhoneModel> Phones { get; set; }

        #endregion Public Properties
    }
}
