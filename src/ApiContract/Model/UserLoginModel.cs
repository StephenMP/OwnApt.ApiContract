using Microsoft.AspNetCore.Identity;
using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Model
{
    public class UserLoginModel : Equatable<UserLoginModel>
    {
        #region Public Properties

        public string Email { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public PasswordVerificationResult VerificationResult { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override int GetHashCode()
        {
            return this.Email.GetHashCodeSafe()
                ^ this.Password.GetHashCodeSafe()
                ^ this.UserId.GetHashCodeSafe()
                ^ this.VerificationResult.GetHashCodeSafe();
        }

        #endregion Public Methods
    }
}
