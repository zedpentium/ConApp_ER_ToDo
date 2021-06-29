using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp_ER_ToDo.Model
{
    public class ToDo
    {

        readonly int todoId;
        string description;
        bool done;
        Person assignee;

        public ToDo(int todoIdCon, string descriptionCon) 
        {
 
            TodoId = todoIdCon; // Why? passes the value to getsetter class property, so u can set the private field & have input validation if needed
            Description = descriptionCon;
        }

        public int TodoId
        {
            get
            {
                return todoId;
            }
            set
            {
                // blank coz cannot set readonly int todoId
            }
        }

        public string Description  
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



 



    }
}
