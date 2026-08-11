namespace QuanLyKhachSan
{
    public class HotelService
    {
        public string ServiceId { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }

        public HotelService() { }

        public HotelService(string serviceId, string serviceName, decimal unitPrice)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            UnitPrice = unitPrice;
        }
    }
}
