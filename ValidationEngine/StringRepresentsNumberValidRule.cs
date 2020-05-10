using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public class StringRepresentsNumberValidRule : ValidationRule
    {
        private string Data { get; set; }

        public StringRepresentsNumberValidRule(string data)
        {
            Data = data;
        }

        public override bool IsValid()
        {
            if(String.IsNullOrWhiteSpace(Data))
            {
                return false;
            }

            foreach(Char c in Data)
            {
                if(!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
