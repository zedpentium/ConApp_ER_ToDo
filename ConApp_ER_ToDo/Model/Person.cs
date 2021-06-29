using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Model
{
    public class Person
    {
        static int idCounter = 0;
        
        public static int Counter { get { return idCounter; } }


        private readonly int personId;
        private string firstName;
        private string lastName;
        //private int personAssignedId;

        public Person(string firstName, string lastName)
        {
            personId = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
        }

        public int PersonId
        {
            get
            {
                return personId;
            }
            set
            {
                //personAssignedId = PersonId;
            }
        }


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




    }
}
