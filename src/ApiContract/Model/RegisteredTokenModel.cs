using OwnApt.Common.Dto;
using System;

namespace OwnApt.Api.Contract.Model
{
    public class RegisteredTokenModel : Equatable
    {
        #region Public Properties

        public string Token { get; set; }
        public string Id { get; set; }
        public string Nonce { get; set; }
        public string[] PropertyIds { get; set; }
        public string SuppliedNonce { get; set; }
        public DateTime UtcDateIssued { get; set; }

        #endregion Public Properties
    }
}
