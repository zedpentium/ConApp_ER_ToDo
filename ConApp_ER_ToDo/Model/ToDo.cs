using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Model
{
    public class ToDo
    {

        public int PtodoId = 0;
        readonly int todoId;
        string description;
        bool done;
        Person assignee;



        public int TodoId
        {
            get { return PtodoId; } // temporary a public int instead of the private int
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Null/Empty or only whitespace is not allowed.");
                //}

                PtodoId = value; // temporary a public int instead of the private int
            }
        }

        public string Description  // properties with SET validation to not input Null/empty or ""
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Null/Empty or only whitespace is not allowed.");
                }

                description = value;
            }
        }



        public ToDo(int todoId, string description) // 
        {
            //todoId = ++PtodoId;
            TodoId = todoId;
            Description = description;
        }




    }
}
