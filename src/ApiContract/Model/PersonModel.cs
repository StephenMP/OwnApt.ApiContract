using OwnApt.Api.Contract.Dto;
using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class PersonModel : Equatable<PersonModel>
    {
        #region Properties

        public int Age { get; set; }
        public ContactModel Contact { get; set; }
        public int CreditScore { get; set; }
        public Gender Gender { get; set; }
        public string Id { get; set; }
        public NameModel Name { get; set; }
        public string[] PropertyIds { get; set; }
        public PersonType Type { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Id.GetHashCodeSafe()
                ^ this.PropertyIds.GetHashCodeSafe()
                ^ this.Type.GetHashCodeSafe()
                ^ this.Name.GetHashCodeSafe()
                ^ this.Age.GetHashCodeSafe()
                ^ this.Gender.GetHashCodeSafe()
                ^ this.CreditScore.GetHashCodeSafe()
                ^ this.Contact.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
