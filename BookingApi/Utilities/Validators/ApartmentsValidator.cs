using System;
using FluentValidation;

namespace BookingApi.Utilities.Validators
{
    public class ApartmentsValidator : AbstractValidator<Apartments>
    {
        public ApartmentsValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("name format is incorrect");

        }
    }
}

