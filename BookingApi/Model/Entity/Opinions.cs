using System;
namespace BookingApi.Model.Entity
{
    public class Opinions:IEntity
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public string Opinion { get; set; }
    }
}

