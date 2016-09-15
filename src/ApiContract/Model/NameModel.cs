using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class NameModel : Equatable
    {
        #region Public Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        #endregion Public Properties
    }
}
