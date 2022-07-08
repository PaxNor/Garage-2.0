namespace Garage_2._0.Models
{
    public class OverviewViewModel
    {
        public int Id { get; set; }
        public string? RegNbr { get; set; }
        public string? Type { get; set; }

        public DateTime ParkTime { get; set; }
        public double ParkedTime  { get; set; }
    }
}
