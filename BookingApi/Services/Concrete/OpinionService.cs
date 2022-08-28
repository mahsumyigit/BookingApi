using System;
using System.Xml.Linq;

namespace BookingApi.Services.Concrete
{
    public class OpinionService : IOpinionService
    {
        private IOpinionRepository _opinionRepository;

        public OpinionService(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }

        public IResult Add(Opinions entity)
        {
            var FindedOpinions = _opinionRepository.Get(u => u.Id == entity.Id);
            if (FindedOpinions == null)
            {
                _opinionRepository.Add(entity);
                return new SuccessResult("Add Opinions successful.");
            }
            return new ErrorResult("Opinions to be added already exists.");
        }

        public IResult Delete(Opinions entity)
        {
            var FindedOpinions = _opinionRepository.Get(u => u.Id == entity.Id);
            if (FindedOpinions != null)
            {
                _opinionRepository.Delete(entity);
                return new SuccessResult("Opinions user successful.");
            }
            return new ErrorResult("No Opinions found to delete.");
        }

        public IDataResult<List<Opinions>> GetAll()
        {
            return new SuccessDataResult<List<Opinions>>(_opinionRepository.GetAll());
        }

        public IDataResult<Opinions> GetOpinionsById(int id)
        {
            return new SuccessDataResult<Opinions>(_opinionRepository.Get(u => u.Id == id));
        }

        public IDataResult<Opinions> GetOpinionsByOpinion(string Opinion)
        {
            var FindedOpinions = _opinionRepository.Get(u => u.Opinion == Opinion);
            if (FindedOpinions != null)
            {
                return new SuccessDataResult<Opinions>(FindedOpinions, "The requested Opinions has been brought.");
            }
            return new ErrorDataResult<Opinions>("requested Opinions not found.");
        }

        public IResult Update(Opinions entity)
        {
            var FindedOpinions = _opinionRepository.Get(u => u.Id == entity.Id);
            if (FindedOpinions != null)
            {
                _opinionRepository.Update(entity);
                return new SuccessResult("Update Opinions successful.");
            }
            return new ErrorResult("No Opinions found to update.");
        }
    }
}

