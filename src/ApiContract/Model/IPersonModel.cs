using OwnApt.Api.Contract.Dto;
using OwnApt.Common.Enum;

namespace OwnApt.Api.Contract.Model
{
    public interface IPersonModel
    {
        #region Public Properties

        int Age { get; }
        IContactDto Contact { get; }
        int CreditScore { get; }
        Gender Gender { get; }
        string Id { get; }
        INameDto Name { get; }
        string[] PropertyIds { get; }
        PersonType Type { get; }

        #endregion Public Properties
    }
}
