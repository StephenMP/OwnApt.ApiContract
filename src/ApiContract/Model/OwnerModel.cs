using OwnApt.Common.Dto;
using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Model
{
    public class OwnerModel : Equatable
    {
        #region Public Properties

        public BirthdateModel Birthdate { get; set; }
        public ContactModel Contact { get; set; }
        public ContactModel EmergencyContact { get; set; }
        public Gender Gender { get; set; }
        public string Id { get; set; }
        public NameModel Name { get; set; }
        public string[] PropertyIds { get; set; }

        #endregion Public Properties
    }
}
