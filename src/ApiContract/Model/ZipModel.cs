using OwnApt.Common.Dto;

namespace OwnApt.Api.Contract.Model
{
    public class ZipModel : Equatable
    {
        #region Public Properties

        public string Base { get; set; }
        public string Extension { get; set; }

        #endregion Public Properties
    }
}
