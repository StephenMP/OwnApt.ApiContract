using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class ContactDto : Equatable<ContactDto>
    {
        #region Properties

        public string Email { get; set; }
        public PhoneDto[] Phones { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Email.GetHashCodeSafe()
                 ^ this.Phones.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
