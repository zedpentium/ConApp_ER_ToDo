﻿using System;
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


        public ToDo[] RemoveOneToDoItemRebuildArray(ToDo removeThisToDoItem)
        {
            //ToDo[] toDoItemIndexRemove = Array.FindAll(_arrOfTodoObjects, idNr => idNr != removeThisToDoItem);
            //_arrOfTodoObjects = toDoItemIndexRemove;  
            // efficient code above here, but not correct according to instructions.
            // According to instructions, i must find index, and then exclude it, when rebuilding array
            // so here is that, in the code below /ER

            ToDo[] beforeCopyArray = new ToDo[_arrOfTodoObjects.Length];

            int toDoItemIndexRemove = Array.FindIndex(_arrOfTodoObjects, idNr => idNr == removeThisToDoItem);

            _arrOfTodoObjects.CopyTo(beforeCopyArray, 0);

            _arrOfTodoObjects[toDoItemIndexRemove] = null;

            _arrOfTodoObjects = Array.FindAll(_arrOfTodoObjects, idNr => idNr != null);

            return beforeCopyArray; // this is returning a separate Array BEFORE 1 object was removed in _arrOfTodoObjects
                                    // to compare this BEFORE, with AFTER removal in x Unit test.

        }



        // UPDATE 2021-07-05 - 10:12 - The object IS referenced. SO all objects i update, WILL update in array,
        // coz there IS only 1 object, and its referenced when using fields or prop to update info! ;)
        // Method below is for x unit testing, To store objects i update in testing, and need to store in _arrOfTodoObjects array
        // to be able to search for set things in the objects in the array and get them

        /*public void StoreUppdatedObject(ToDo updatedToDoObject, int inputToDoId) 
        {
            int toDoItemIndex = Array.FindIndex(_arrOfTodoObjects, idNr => idNr.ToDoId == inputToDoId);
            _arrOfTodoObjects[toDoItemIndex] = updatedToDoObject;

        }
        */




    }
}
