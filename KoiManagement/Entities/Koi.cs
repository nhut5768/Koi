namespace KoiManagement.Entities
{
    public class Koi
    {
        public required string Name { get; set; } = string.Empty; // Đảm bảo có giá trị mặc định
        public required string Variety { get; set; } = string.Empty; // Đảm bảo có giá trị mặc định
        public int Age { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
    }
}