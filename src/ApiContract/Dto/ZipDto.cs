using OwnApt.Common.Dto;
using OwnApt.Common.Extension;

namespace OwnApt.Api.Contract.Dto
{
    public class ZipDto : Equatable<ZipDto>
    {
        #region Properties

        public string Base { get; set; }
        public string Extension { get; set; }

        #endregion Properties

        #region Methods

        public override int GetHashCode()
        {
            return this.Base.GetHashCodeSafe()
                ^ this.Extension.GetHashCodeSafe();
        }

        #endregion Methods
    }
}
