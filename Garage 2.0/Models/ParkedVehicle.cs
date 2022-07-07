namespace Garage_2._0.Models
{
    public class  ParkedVehicle
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? RegNbr  { get; set; }
        public string? Color { get; set; } 
        public string? Brand { get; set; }  
        public string? Model { get; set; }
        public int? wheelCount { get; set; }
        public DateTime ParkTime { get; set; }

    }
}
