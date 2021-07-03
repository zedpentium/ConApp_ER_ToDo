using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Data
{
    public class TodoSequencer
    {

        private static int _todoid; // i have underscore on theese private fields, to differentiante them visually


        public static int NextToDoId()
            {

            _todoid = ++_todoid;

            return _todoid;
            }



        public static void ToDoReset()
        {
            TodoItems doAnClear = new TodoItems();
            doAnClear.Clear();
            _todoid = 0;
        }



    }
}
