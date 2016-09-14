using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class NameModel : Equatable<NameModel>
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCodeSafe()
                ^ this.MiddleName.GetHashCodeSafe()
                ^ this.LastName.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
