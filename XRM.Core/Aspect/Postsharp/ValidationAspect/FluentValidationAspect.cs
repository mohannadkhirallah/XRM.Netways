using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Linq;
using XRM.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace XRM.Core.Aspect.Postsharp.ValidationAspect
{
    [Serializable]
    public class FluentValidationAspect :OnMethodBoundaryAspect
    {
        private readonly Type validatorType;

        public FluentValidationAspect(Type validatorType)
        {
            this.validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator =(IValidator) Activator.CreateInstance(validatorType); 
            var entityType = validatorType.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach ( var entity in entities )
            {
                ValidationTool.FluentValidate(validator, entity);
            }
        }
       
    }
}
