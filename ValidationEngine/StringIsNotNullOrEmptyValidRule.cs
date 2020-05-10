using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public class StringIsNotNullOrEmptyValidRule : ValidationRule
    {
        private string Data { get; set; }
        public StringIsNotNullOrEmptyValidRule(string data)
        {
            Data = data;
        }

        public override bool IsValid()
        {
            if(String.IsNullOrEmpty(Data))
                return false;

            return true;
        }
    }
}
