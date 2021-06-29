using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Data
{
    public class TodoSequencer
    {

        private static int personId;

        public TodoSequencer(int personId)
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



        public static int NextToDoId(int toDoIdNext)
            {

            PersonId = ++toDoIdNext;

            return PersonId;
            }



        public static void ToDoReset()
        {
            PersonId = 0;
        }



    }
}
