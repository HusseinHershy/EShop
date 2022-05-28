using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{Product Name} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{Product Name} must not exceed 50 characters.");


            RuleFor(p => p.Color).NotEmpty().WithMessage("{Color Name} is required.")
                .NotNull();

            RuleFor(p => p.CategoryName)
              .NotNull().WithMessage("{Category Name} is required.");
             

        }

    }

}
