namespace BookingApi.Model.Entity
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string JobType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int OnBoardindCompletion { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }

    }
}