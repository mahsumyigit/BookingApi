using System;
namespace BookingApi.Model.Entity
{
    public class Apartments:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }
        public string Cıty { get; set; }
        public string ZipCode { get; set; }
        public string Adress { get; set; }
        public string Adress2 { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Direction { get; set; }
        public int Booked { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }

    }
}

