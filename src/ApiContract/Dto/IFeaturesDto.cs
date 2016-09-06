namespace OwnApt.Api.Contract.Dto
{
    public interface IFeaturesDto
    {
        #region Public Properties

        IAmmenityDto[] Ammentities { get; }
        double Bathrooms { get; }
        int Levels { get; }
        IParkingDto Parking { get; }
        int Rooms { get; }

        #endregion Public Properties
    }
}
