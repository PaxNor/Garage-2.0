namespace Garage_2._0.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public DateTime ArrivalTime { get; set; }

        public int? VehicleId { get; set; }
    }
}
