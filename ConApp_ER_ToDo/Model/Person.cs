using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Model
{
    public class Person
    {
        static int idCounter = 0;
        public static int Counter { get { return idCounter; } }

        public int pubPersonId;

        readonly int personId;

        string firstName;
        string lastName;


        public string FirstName // properties with SET validation to not input Null/empty or ""
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Null/Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName // properties with SET validation to not input Null/empty or ""
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Null/Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }


        //, int personId
        //  PersonId = personId
        public Person(string firstName, string lastName)
        {
            pubPersonId = ++idCounter;  // temporary a public int instead of the private int
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




        //public int PersonId
        //{
        //    get { return personId; }
        //    set
        //    {
        //        //if (string.IsNullOrWhiteSpace(value))
        //        //{
        //        //    throw new ArgumentException("Empty or only whitespace is not allowed.");
        //        //}

        //        personId = value;
        //    }
        //}



    }
}
