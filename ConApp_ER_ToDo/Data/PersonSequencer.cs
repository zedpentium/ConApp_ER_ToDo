using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Data
{
    public class PersonSequencer
    {

        private static int _personId = 0;


        public static int NextPersonId()
            {

            _personId = _personId + 1;

            return _personId;
            }



        public static void Reset()
        {
            _personId = 0;
        }



    }
}
