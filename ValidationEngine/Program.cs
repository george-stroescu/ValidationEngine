using System;
using System.Runtime.CompilerServices;

namespace ValidationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = { 
                new Person
                {
                    FirstName = "John",
                    LastName = "Cena",
                    CNP = "13654527247",
                    Age = "30",
                },
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    CNP = "13654527247",
                    Age = "17",
                },
                new Person
                {
                    FirstName = "Johnny",
                    LastName = "Bravo",
                    CNP = "13afdagafdg654527247",
                    Age = "20",
                },
                new Person
                {
                    FirstName = "Johnny",
                    LastName = "Depp!~",
                    CNP = "13654527247",
                    Age = "50",
                }
            };

            PersonListProcessor personListProcessor = new PersonListProcessor(persons);

            personListProcessor.Process();
        }
    }
}
