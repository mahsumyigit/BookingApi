using System;
namespace BookingApi.Model.Entity
{
    public class Bookings
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string StartsAt { get; set; }
        public string BookedAt { get; set; }
        public int ApartmenId { get; set; }
        public int Confirmed { get; set; }
        public  Apartments Apartments { get; set; }
        public User User { get; set; }
    }
}

