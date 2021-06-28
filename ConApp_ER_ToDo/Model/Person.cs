using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Model
{
    public class Person
    {
        static int idCounter;

        public int personIdnr;

        readonly int personId;

        string firstName;
        string lastName;


        //, int personId
        //  PersonId = personId
        public Person(string firstName, string lastName)
        {
            personIdnr = ++idCounter;
            FirstName = firstName;
            LastName = lastName;

        }

        //// A read-write instance property:
        //public string Name
        //{
        //    get => _name;
        //    set => _name = value;
        //}

        //// A read-only static property:
        //public static int Counter => _counter;



        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }
        public int PersonId
        {
            get { return personIdnr; }
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Empty or only whitespace is not allowed.");
                //}

                personIdnr = value;
            }
        }



    }
}
