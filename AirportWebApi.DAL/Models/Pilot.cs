using FluentValidation;
using FluentValidation.Attributes;
using System;

namespace AirportApi.Models
{
    [Validator(typeof(PilotValidator))]
    public class Pilot
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Experience { get; set; }

    }

    public class PilotValidator : AbstractValidator<Pilot>
    {
        public PilotValidator()
        {
            //RuleFor(x => x.Name).Length(8, 999).WithMessage("The user name must be at least 8 characters long.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("The First Name cannot be blank.")
                                        .Length(0, 10).WithMessage("The First Name cannot be more than 100 characters.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("The Last Name cannot be blank.");

            RuleFor(x => x.Birthday).LessThan(DateTime.Today).WithMessage("You cannot enter a birth date in the future.");
        }
    }
}
