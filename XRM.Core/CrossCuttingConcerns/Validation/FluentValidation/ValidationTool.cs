using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRM.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
