namespace QuanLyKhachSan
{
    public class Customer
    {
        public string CustomerId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;

        public Customer() { }

        public Customer(string customerId, string fullName, string phoneNumber, string roomNumber)
        {
            CustomerId = customerId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            RoomNumber = roomNumber;
        }
    }
}
