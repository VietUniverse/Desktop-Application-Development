using System;

namespace QuanLyKhachSan
{
    public class ServiceUsage
    {
        public string UsageId { get; set; } = Guid.NewGuid().ToString("N")[..8];
        public string RoomNumber { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        public string ServiceId { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
        public DateTime UsageDate { get; set; } = DateTime.Now;

        public ServiceUsage() { }

        public ServiceUsage(string roomNumber, string customerId, string serviceId, string serviceName, int quantity, decimal unitPrice, DateTime usageDate)
        {
            RoomNumber = roomNumber;
            CustomerId = customerId;
            ServiceId = serviceId;
            ServiceName = serviceName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            UsageDate = usageDate;
        }
    }
}
