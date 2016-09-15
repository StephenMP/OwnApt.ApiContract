using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class NameModel : Equatable<NameModel>
    {
        #region Public Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCodeSafe()
                ^ this.MiddleName.GetHashCodeSafe()
                ^ this.LastName.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
