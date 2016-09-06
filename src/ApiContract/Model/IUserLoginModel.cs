using Microsoft.AspNetCore.Identity;

namespace OwnApt.Api.Contract.Model
{
    public interface IUserLoginModel
    {
        #region Public Properties

        string Email { get; }
        string Password { get; }
        string UserId { get; }
        PasswordVerificationResult VerificationResult { get; }

        #endregion Public Properties
    }
}
