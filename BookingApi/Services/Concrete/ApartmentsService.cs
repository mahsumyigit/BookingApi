using System;
using BookingApi.Model.Entity;
using BookingApi.Services.Interfaces;

namespace BookingApi.Services.Concrete
{
    public class ApartmentsService : IApartmentsService
    {
        private IApartmentsRepository _apartmentRepository;

        public ApartmentsService(IApartmentsRepository apartmentRepository)
        {
        }

        public IResult Add(Apartments entity)
        {
            var FindedAparments = _apartmentRepository.Get(u => u.Name == entity.Name);
            if (FindedAparments == null)
            {
                _apartmentRepository.Add(entity);
                return new SuccessResult("Add apartment successful.");
            }
            return new ErrorResult("apartment to be added already exists.");
        }

        public IResult Delete(Apartments entity)
        {
            var FindedAparments = _apartmentRepository.Get(u => u.Name == entity.Name);
            if (FindedAparments != null)
            {
                _apartmentRepository.Delete(entity);
                return new SuccessResult("Apartments user successful.");
            }
            return new ErrorResult("No Apartments found to delete.");
        }

        public IDataResult<List<Apartments>> GetAll()
        {
            return new SuccessDataResult<List<Apartments>>(_apartmentRepository.GetAll());
        }

        public IDataResult<Apartments> GetApartmentsById(int id)
        {
            return new SuccessDataResult<Apartments>(_apartmentRepository.Get(u => u.Id == id));
        }

        public IDataResult<Apartments> GetApartmentsByName(string Name)
        {
            var FindedAparments = _apartmentRepository.Get(u => u.Name == Name);
            if (FindedAparments != null)
            {
                return new SuccessDataResult<Apartments>(FindedAparments, "The requested Apartments has been brought.");
            }
            return new ErrorDataResult<Apartments>("requested Apartments not found.");
        }

        public IResult Update(Apartments entity)
        {
            var FindedAparments = _apartmentRepository.Get(u => u.Id == entity.Id);
            if (FindedAparments != null)
            {
                _apartmentRepository.Update(entity);
                return new SuccessResult("Update Apartments successful.");
            }
            return new ErrorResult("No Apartments found to update.");
        }
    }
}

