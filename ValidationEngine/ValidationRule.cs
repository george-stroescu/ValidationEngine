using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public abstract class ValidationRule
    {
        public abstract bool IsValid();
    }
}
