namespace Garage_2._0.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string RegNbr { get; set; }  
        public string Color { get; set; }
        public int WheelCount { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public VehicleType VehicleType { get; set; }
        public Parking? Parking { get; set; }
        //public List<VehicleType> VehicleTypes { get; set; } = new List<VehicleType>();
        public int MemberId { get; set; }
    }
}
