using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Data
{
    public class PersonSequencer
    {

        private static int personId;

        public PersonSequencer(int personId)
        {
            PersonId = personId;
        }

        public static int PersonId
            {
            get
                {
                    return personId;
                }
            set
                {
                    personId = value;
                }
            }



        public static int NextPersonId(int personIdNext)
            {

            PersonId = ++personIdNext;

            return PersonId;
            }



        public static void Reset()
        {
            PersonId = 0;
        }



    }
}
