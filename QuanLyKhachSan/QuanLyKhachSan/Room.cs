namespace QuanLyKhachSan
{
    public class Room
    {
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
        public decimal PricePerNight { get; set; }
        public bool IsOccupied { get; set; }

        public Room() { }

        public Room(string roomNumber, string roomType, decimal pricePerNight, bool isOccupied = false)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsOccupied = isOccupied;
        }
    }
}
