namespace BookingApi.Services.Interfaces
{
    public interface IApartmentsService:IServiceBase<Apartments>
    {
        IDataResult<Apartments> GetApartmentsById(int id);
        IDataResult<Apartments> GetApartmentsByName(string Name);
        IDataResult<List<Apartments>> GetAll();
    }
}

