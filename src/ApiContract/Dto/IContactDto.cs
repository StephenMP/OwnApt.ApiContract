namespace OwnApt.Api.Contract.Dto
{
    public interface IContactDto
    {
        #region Public Properties

        string Email { get; }
        IPhoneDto[] Phones { get; }

        #endregion Public Properties
    }
}
