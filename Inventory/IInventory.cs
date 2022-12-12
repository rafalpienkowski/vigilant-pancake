namespace Inventory;

public interface IInventory
{
    Task<Reservation> MakeReservation(ReservationRequest request);
}