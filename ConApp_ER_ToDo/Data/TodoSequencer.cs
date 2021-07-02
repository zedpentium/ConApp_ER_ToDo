using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Data
{
    public class TodoSequencer
    {

        private static int _todoid;


        public static int NextToDoId()
            {

            _todoid = ++_todoid;

            return _todoid;
            }



        public static void ToDoReset()
        {
            _todoid = 0;
        }



    }
}
