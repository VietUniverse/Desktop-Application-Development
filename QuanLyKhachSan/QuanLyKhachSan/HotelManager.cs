using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan
{
    public class HotelManager
    {
        public List<Room> Rooms { get; } = new List<Room>();
        public List<Customer> Customers { get; } = new List<Customer>();
        public List<HotelService> Services { get; } = new List<HotelService>();
        public List<ServiceUsage> Usages { get; } = new List<ServiceUsage>();

        public HotelManager()
        {
            SeedInitialData();
        }

        private void SeedInitialData()
        {
            // Initial Rooms
            Rooms.Add(new Room("P101", "Standard Single", 500000, true));
            Rooms.Add(new Room("P102", "Standard Double", 750000, true));
            Rooms.Add(new Room("P201", "VIP Ocean View", 1200000, true));
            Rooms.Add(new Room("P202", "Luxury Suite", 2000000, false));

            // Initial Services
            Services.Add(new HotelService("DV01", "Giặt ủi", 30000));
            Services.Add(new HotelService("DV02", "Nước khoáng", 15000));
            Services.Add(new HotelService("DV03", "Massage thư giãn", 350000));
            Services.Add(new HotelService("DV04", "Tắm hơi thảo dược", 250000));
            Services.Add(new HotelService("DV05", "Ăn sáng tại phòng", 100000));

            // Initial Customers
            Customers.Add(new Customer("KH01", "Nguyễn Văn An", "0901234567", "P101"));
            Customers.Add(new Customer("KH02", "Trần Thị Bình", "0912345678", "P102"));
            Customers.Add(new Customer("KH03", "Lê Hoàng Cường", "0923456789", "P201"));

            // Initial Usages today
            DateTime today = DateTime.Today;
            Usages.Add(new ServiceUsage("P101", "KH01", "DV01", "Giặt ủi", 3, 30000, today));
            Usages.Add(new ServiceUsage("P101", "KH01", "DV02", "Nước khoáng", 5, 15000, today));
            Usages.Add(new ServiceUsage("P102", "KH02", "DV03", "Massage thư giãn", 1, 350000, today));
            Usages.Add(new ServiceUsage("P201", "KH03", "DV04", "Tắm hơi thảo dược", 2, 250000, today));
            Usages.Add(new ServiceUsage("P201", "KH03", "DV02", "Nước khoáng", 4, 15000, today));
        }

        // --- Yêu cầu 1: CRUD Phòng ---
        public bool AddRoom(Room room)
        {
            if (Rooms.Any(r => r.RoomNumber.Equals(room.RoomNumber, StringComparison.OrdinalIgnoreCase)))
                return false;
            Rooms.Add(room);
            return true;
        }

        public bool UpdateRoom(Room room)
        {
            var existing = Rooms.FirstOrDefault(r => r.RoomNumber.Equals(room.RoomNumber, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            existing.RoomType = room.RoomType;
            existing.PricePerNight = room.PricePerNight;
            existing.IsOccupied = room.IsOccupied;
            return true;
        }

        public bool DeleteRoom(string roomNumber)
        {
            var existing = Rooms.FirstOrDefault(r => r.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            Rooms.Remove(existing);
            return true;
        }

        // --- Yêu cầu 2: CRUD Khách hàng ---
        public bool AddCustomer(Customer customer)
        {
            if (Customers.Any(c => c.CustomerId.Equals(customer.CustomerId, StringComparison.OrdinalIgnoreCase)))
                return false;
            Customers.Add(customer);
            return true;
        }

        public bool UpdateCustomer(Customer customer)
        {
            var existing = Customers.FirstOrDefault(c => c.CustomerId.Equals(customer.CustomerId, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            existing.FullName = customer.FullName;
            existing.PhoneNumber = customer.PhoneNumber;
            existing.RoomNumber = customer.RoomNumber;
            return true;
        }

        public bool DeleteCustomer(string customerId)
        {
            var existing = Customers.FirstOrDefault(c => c.CustomerId.Equals(customerId, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            Customers.Remove(existing);
            return true;
        }

        // --- Yêu cầu 3: CRUD Dịch vụ ---
        public bool AddService(HotelService service)
        {
            if (Services.Any(s => s.ServiceId.Equals(service.ServiceId, StringComparison.OrdinalIgnoreCase)))
                return false;
            Services.Add(service);
            return true;
        }

        public bool UpdateService(HotelService service)
        {
            var existing = Services.FirstOrDefault(s => s.ServiceId.Equals(service.ServiceId, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            existing.ServiceName = service.ServiceName;
            existing.UnitPrice = service.UnitPrice;
            return true;
        }

        public bool DeleteService(string serviceId)
        {
            var existing = Services.FirstOrDefault(s => s.ServiceId.Equals(serviceId, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return false;
            Services.Remove(existing);
            return true;
        }

        // --- Yêu cầu 4: Bảng giá dịch vụ theo thứ tự từ điển ---
        public List<HotelService> GetServicesAlphabetical()
        {
            return Services.OrderBy(s => s.ServiceName, StringComparer.OrdinalIgnoreCase).ToList();
        }

        // --- Yêu cầu 5: Liệt kê phòng / khách hàng sử dụng dịch vụ cụ thể ---
        public List<string> GetRoomsUsingService(string serviceId)
        {
            return Usages
                .Where(u => u.ServiceId.Equals(serviceId, StringComparison.OrdinalIgnoreCase))
                .Select(u => u.RoomNumber)
                .Distinct()
                .ToList();
        }

        public List<Customer> GetCustomersUsingService(string serviceId)
        {
            var roomNumbers = GetRoomsUsingService(serviceId);
            return Customers
                .Where(c => roomNumbers.Contains(c.RoomNumber, StringComparer.OrdinalIgnoreCase))
                .ToList();
        }

        // --- Yêu cầu 6: Tính tiền dịch vụ cho một phòng ---
        public decimal CalculateRoomServiceBill(string roomNumber)
        {
            return Usages
                .Where(u => u.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase))
                .Sum(u => u.TotalPrice);
        }

        public List<ServiceUsage> GetRoomServiceDetails(string roomNumber)
        {
            return Usages
                .Where(u => u.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // --- Yêu cầu 7: Thống kê thu nhập trong ngày từ dịch vụ ---
        public decimal GetDailyServiceRevenue(DateTime date)
        {
            return Usages
                .Where(u => u.UsageDate.Date == date.Date)
                .Sum(u => u.TotalPrice);
        }

        public Dictionary<string, decimal> GetDailyRevenueByService(DateTime date)
        {
            return Usages
                .Where(u => u.UsageDate.Date == date.Date)
                .GroupBy(u => u.ServiceName)
                .ToDictionary(g => g.Key, g => g.Sum(u => u.TotalPrice));
        }
    }
}
