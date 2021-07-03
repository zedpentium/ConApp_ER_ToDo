using System;
using System.Collections.Generic;
using System.Text;
using ConApp_ER_ToDo.Model;

namespace ConApp_ER_ToDo.Data
{
    public class TodoItems
    {

        private static ToDo[] _arrOfTodoObjects = new ToDo[0]; // i have underscore on this private object array, to differentiante them visually


        public int Size()
        {
            return _arrOfTodoObjects.Length;
        }

        public ToDo[] FindAllToDoItems()
        {
            return _arrOfTodoObjects;
        } 


        public ToDo FindByTodoId(int todoId)
        {
            ToDo foundObjectIndex = Array.Find(_arrOfTodoObjects, idNr => idNr.ToDoId == todoId);

            return foundObjectIndex;
        }

        public ToDo CreateNewTodoToArray(string description)
        {
            ToDo newTodoInfo = new ToDo(TodoSequencer.NextToDoId(), description);

            Array.Resize(ref _arrOfTodoObjects, 1 + Size()); // adding 1 more element to array to make room for the newPersonInfo object

            _arrOfTodoObjects[Size() - 1] = newTodoInfo;

            return newTodoInfo;

        }


        public void Clear()
        {
            Array.Resize(ref _arrOfTodoObjects, 0);
            PersonSequencer.Reset();

        }


        public ToDo[] FindByDoneStatus(bool doneStatus)
        {
            ToDo[] foundDoneObject = Array.FindAll(_arrOfTodoObjects, idNr => idNr.Done == doneStatus);

            return foundDoneObject;
        }


        public ToDo[] FindByAssignee(int personId)
        {
            ToDo[] thePersonsWithAssignee = Array.FindAll(_arrOfTodoObjects, idNr => idNr.Assignee != null );
            ToDo[] foundBypersonId = Array.FindAll(thePersonsWithAssignee, idNr => idNr.Assignee.PersonId == personId);

            return foundBypersonId;
        }

        public ToDo[] FindByAssignee(Person assignee)
        {
            ToDo[] foundDoneObject = Array.FindAll(_arrOfTodoObjects, idNr => idNr.Assignee == assignee);

            return foundDoneObject;
        }

        public ToDo[] FindUnassignedTodoItems()
        {
            ToDo[] foundDoneObject = Array.FindAll(_arrOfTodoObjects, idNr => idNr.Assignee == null);

            return foundDoneObject;
        }



        // Method below is for x unit testing, To store objects i update in testing, and need to store in _arrOfTodoObjects array
        // to be able to search for set things in the objects in the array and get them

        public void StoreUppdatedObject(ToDo updatedToDoObject, int inputToDoId) 
        {
            int PersonObjIndex = Array.FindIndex(_arrOfTodoObjects, idNr => idNr.ToDoId == inputToDoId);
            _arrOfTodoObjects[PersonObjIndex] = updatedToDoObject;

        }




    }
}
