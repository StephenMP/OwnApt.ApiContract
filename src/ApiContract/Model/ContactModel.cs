using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class ContactModel : Equatable<ContactModel>
    {
        #region Public Properties

        public string Email { get; set; }
        public PhoneModel[] Phones { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return this.Email.GetHashCodeSafe()
                 ^ this.Phones.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
