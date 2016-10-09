using System.Collections.Generic;
using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class ContactModel : Equatable
    {
        #region Public Constructors

        public ContactModel()
        {
            this.Phones = new List<PhoneModel>();
        }

        #endregion Public Constructors

        #region Public Properties

        public string Email { get; set; }
        public AddressModel HomeAddress { get; set; }
        public List<PhoneModel> Phones { get; set; }

        #endregion Public Properties
    }
}
