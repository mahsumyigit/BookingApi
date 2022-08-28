using System;
namespace BookingApi.Services.Interfaces
{
    public interface IOpinionService:IServiceBase<Opinions>
    {
        IDataResult<Opinions> GetOpinionsById(int id);
        IDataResult<Opinions> GetOpinionsByOpinion(string Opinion);
        IDataResult<List<Opinions>> GetAll();
    }
}

