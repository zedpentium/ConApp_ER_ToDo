using System;
using System.Collections.Generic;
using System.Text;
using ConApp_ER_ToDo.Model;

namespace ConApp_ER_ToDo.Data
{
    public class TodoItems
    {

        private static ToDo[] arrOfTodoObjects = new ToDo[0];


        public int Size()
        {
            return arrOfTodoObjects.Length;
        }

        public ToDo[] FindAllToDoItems()
        {
            return arrOfTodoObjects;
        } 


        public ToDo FindByTodoId(int todoId)
        {
            ToDo foundObjectIndex = Array.Find(arrOfTodoObjects, idNr => idNr.ToDoId == todoId);

            return foundObjectIndex;
        }

        public ToDo CreateNewTodoToArray(string description)
        {
            ToDo newTodoInfo = new ToDo(TodoSequencer.NextToDoId(), description);

            Array.Resize(ref arrOfTodoObjects, 1 + Size()); // adding 1 more element to array to make room for the newPersonInfo object

            arrOfTodoObjects[Size() - 1] = newTodoInfo;

            return newTodoInfo;

        }


        public void Clear()
        {
            Array.Resize(ref arrOfTodoObjects, 0);
            PersonSequencer.Reset();
        }

        





    }
}
