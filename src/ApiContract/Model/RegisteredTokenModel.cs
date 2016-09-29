using OwnApt.Common.Dto;
using System;
using System.Collections.Generic;

namespace OwnApt.Api.Contract.Model
{
    public class RegisteredTokenModel : Equatable
    {
        #region Public Constructors

        public RegisteredTokenModel()
        {
            this.PropertyIds = new List<string>();
        }

        #endregion Public Constructors

        #region Public Properties

        public string Id { get; set; }
        public string Nonce { get; set; }
        public List<string> PropertyIds { get; set; }
        public string SuppliedNonce { get; set; }
        public string Token { get; set; }
        public DateTime UtcDateIssued { get; set; }

        #endregion Public Properties
    }
}
