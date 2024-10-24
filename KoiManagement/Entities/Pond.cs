namespace KoiManagement.Entities
{
    public class Pond
    {
        public required string Name { get; set; }
        public double Depth { get; set; } // Độ sâu hồ cá (m)
        public double Volume { get; set; } // Thể tích hồ cá (L)
        public double PumpPower { get; set; } // Công suất máy bơm (W)
    }
}