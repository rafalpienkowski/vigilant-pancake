namespace Inventory;

public interface ISpotRepository
{
    Task Save(Spot spot);
    Task<Spot?> GetById(SpotId spotId);
}