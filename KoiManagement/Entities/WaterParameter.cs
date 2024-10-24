using System;

namespace KoiManagement.Entities
{
    public class WaterParameter
    {
        public double Temperature { get; set; } // Nhiệt độ (°C)
        public double Salinity { get; set; } // Lượng muối
        public double PH { get; set; } // pH
        public double O2 { get; set; } // Oxy hòa tan (mg/L)
        public double NO2 { get; set; } // Nitrit (mg/L)
        public double NO3 { get; set; } // Nitrate (mg/L)
        public double PO4 { get; set; } // Phosphate (mg/L)
        public DateTime MeasurementDate { get; set; } // Ngày đo
        public required string PondName { get; set; } // Tên hồ cá mà thông số nước được đo
    }
}