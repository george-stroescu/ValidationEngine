using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public class StringIsAlphabeticValidRule : ValidationRule
    {
        private string Data { get; set; }

        public StringIsAlphabeticValidRule(string data)
        {
            Data = data;
        }

        public override bool IsValid()
        {
            if (String.IsNullOrWhiteSpace(Data))
                return false;

            foreach (Char c in Data)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
