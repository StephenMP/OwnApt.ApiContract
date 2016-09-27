using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class RegisteredTokenModel : Equatable
    {
        #region Public Properties

        public string Token { get; set; }
        public int TokenId { get; set; }

        #endregion Public Properties
    }
}
