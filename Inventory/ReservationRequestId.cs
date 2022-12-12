namespace Inventory;

public record ReservationRequestId(Guid Value)
{
    public static ReservationRequestId NewReservationRequestId => new(Guid.NewGuid());
}