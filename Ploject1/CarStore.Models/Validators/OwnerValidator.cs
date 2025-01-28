using CarStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using CarStore.Models;
namespace CarStore.Models.Validators
{
    public class OwnerValidator : AbstractValidator<Owner>
    {
        public OwnerValidator()
        {
            RuleFor(o => o.Name)
                .NotEmpty().WithMessage("Name is required");

            RuleFor(o => o.Email)
                .EmailAddress().WithMessage("Valid email is required");
        }
    }
}