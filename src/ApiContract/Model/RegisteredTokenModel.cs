using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class RegisteredTokenModel : Equatable
    {
        #region Public Properties

        public string Token { get; set; }
        public string Id { get; set; }

        #endregion Public Properties
    }
}
