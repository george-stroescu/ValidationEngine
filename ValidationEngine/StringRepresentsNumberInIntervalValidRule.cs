using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    public class StringRepresentsNumberInIntervalValidRule : ValidationRule
    {
        private int From { get; set; }
        private int To { get; set; }
        private string Data { get; set; }

        public StringRepresentsNumberInIntervalValidRule(int from, int to, string data)
        {
            From = from;
            To = to;
            Data = data;
        }

        public override bool IsValid()
        {
            if (String.IsNullOrWhiteSpace(Data))
                return false;

            int number;
            bool isNumber = int.TryParse(Data, out number);

            if(!isNumber)
                return false;

            return ((number >= From) && (number <= To));
        }
    }
}
