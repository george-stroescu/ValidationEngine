using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public class ValidationEngine
    {
        public ValidationRule[] validationRules;

        public ValidationEngine(ValidationRule[] rules)
        {
            validationRules = rules ?? new ValidationRule[0];
        }

        public bool IsValid()
        {
            foreach(ValidationRule rule in validationRules)
            {
                if (rule is null)
                    continue;

                if(!rule.IsValid())
                    return false;
                
            }

            return true;
        }
    }
}
