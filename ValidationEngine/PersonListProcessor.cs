using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine
{
    class PersonListProcessor
    {
        private ValidationRule[] validationRules;
        private ValidationEngine validationEngine;
        private Person[] persons;

        public PersonListProcessor(Person[] p)
        {
            persons = p;
        }

        public void Process()
        {
            foreach (Person p in persons)
            {
                validationRules = new ValidationRule[] { new StringIsNotNullOrEmptyValidRule(p.FirstName), 
                    new StringIsNotNullOrEmptyValidRule(p.LastName),
                    new StringIsAlphabeticValidRule(p.FirstName),
                    new StringIsAlphabeticValidRule(p.LastName),
                    new StringRepresentsNumberValidRule(p.CNP),
                    new StringRepresentsNumberInIntervalValidRule(18, 200,p.Age) };

                validationEngine = new ValidationEngine(validationRules);
                bool isValid = validationEngine.IsValid();

                if (isValid)
                {
                    Console.WriteLine($"Name: {p.FirstName} {p.LastName}, CNP: {p.CNP}, Age: {p.Age}");
                }
                else
                {
                    Console.WriteLine("Validation error");
                }
            }
        }
    }
}
