using OwnApt.Common.Dto;
using OwnApt.Common.Enum;
using System;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class OwnerModel : Equatable
    {
        #region Public Constructors

        public OwnerModel()
        {
            this.Contact = new ContactModel();
            this.EmergencyContact = new ContactModel();
            this.Name = new NameModel();
            this.PropertyIds = new List<string>();
        }

        #endregion Public Constructors

        #region Public Properties

        public DateTime Birthdate { get; set; }
        public ContactModel Contact { get; set; }
        public ContactModel EmergencyContact { get; set; }
        public Gender Gender { get; set; }
        public string Id { get; set; }
        public NameModel Name { get; set; }
        public List<string> PropertyIds { get; set; }

        #endregion Public Properties
    }
}
