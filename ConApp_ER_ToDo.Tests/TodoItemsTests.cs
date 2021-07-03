using System;
using Xunit;
using ConApp_ER_ToDo.Data;
using ConApp_ER_ToDo.Model;


namespace ConApp_ER_ToDo.Tests
{
    public class TodoItemsTests
    {


        [Fact]
        public void TodoItemsClassTesting()
        {
            //Arrange
            string descriptionA = "Städa garaget";
            string descriptionB = "Diska";
            string descriptionC = "Köpa mjölk";
            string descriptionD = "Boka vaccinstid";

            TodoItems testToDo = new TodoItems();



            //Act
            testToDo.Clear();

            ToDo iToDoItemA = testToDo.CreateNewTodoToArray(descriptionA);
            ToDo iToDoItemB = testToDo.CreateNewTodoToArray(descriptionB);
            ToDo iToDoItemC = testToDo.CreateNewTodoToArray(descriptionC);
            ToDo iToDoItemD = testToDo.CreateNewTodoToArray(descriptionD);

            ToDo foundById = testToDo.FindByTodoId(3);

            ToDo[] foundAllOne = testToDo.FindAllToDoItems();
            ToDo[] foundAllTwo = testToDo.FindAllToDoItems();


            //Assert
            Assert.Equal(descriptionA, iToDoItemA.Description);
            Assert.Equal(descriptionB, iToDoItemB.Description);
            Assert.Equal(descriptionC, iToDoItemC.Description);
            Assert.Equal(descriptionD, iToDoItemD.Description);
            Assert.Equal(1, iToDoItemA.ToDoId);
            Assert.Equal(4, iToDoItemD.ToDoId);

            Assert.NotEqual(descriptionB, iToDoItemD.Description);
            Assert.NotEqual(iToDoItemA.ToDoId, iToDoItemC.ToDoId);

            Assert.Equal(iToDoItemC, foundById);
            Assert.NotEqual(iToDoItemB, foundById);

            Assert.Equal(foundAllOne, foundAllTwo);


        }




        [Fact]
        public void TodoItemsClassTestingStep10()
        {
            //Arrange
            string descriptionA = "Städa garaget";
            string descriptionB = "Diska";
            string descriptionC = "Köpa mjölk";
            string descriptionD = "Boka vaccinstid";


            string firstNameA = "Eric";
            string lastNameA = "Rönnhult";
            string firstNameB = "Tomas";
            string lastNameB = "Nilsson";
            string firstNameC = "Mattias";
            string lastNameC = "Bertilsson";
            string firstNameD = "Bernt";
            string lastNameD = "Jonsson";

            TodoItems testToDo = new TodoItems();

            People testPeople = new People();


            //Act
            testToDo.Clear();

            Person iPersonA = testPeople.CreateNewPersonToArray(firstNameA, lastNameA);
            Person iPersonB = testPeople.CreateNewPersonToArray(firstNameB, lastNameB);
            Person iPersonC = testPeople.CreateNewPersonToArray(firstNameC, lastNameC);
            Person iPersonD = testPeople.CreateNewPersonToArray(firstNameD, lastNameD);

            ToDo iToDoItemA = testToDo.CreateNewTodoToArray(descriptionA);
            ToDo iToDoItemB = testToDo.CreateNewTodoToArray(descriptionB);
            ToDo iToDoItemC = testToDo.CreateNewTodoToArray(descriptionC);
            ToDo iToDoItemD = testToDo.CreateNewTodoToArray(descriptionD);

            ToDo[] foundAllUpdatedBefore = testToDo.FindAllToDoItems(); // Before. running theese 2 tests to see if Done status and Assignee
                                                                     // have been properly set, and overwritten object on 
                                                                     // correct index in ToDoItems array.

            iToDoItemA.Assignee = iPersonA;
            iToDoItemD.Assignee = iPersonD;

            iToDoItemA.Done = true;
            iToDoItemB.Done = false;
            iToDoItemC.Done = true;
            iToDoItemD.Done = false;

            testToDo.StoreUppdatedObject(iToDoItemA, iToDoItemA.ToDoId);
            testToDo.StoreUppdatedObject(iToDoItemB, iToDoItemB.ToDoId);
            testToDo.StoreUppdatedObject(iToDoItemC, iToDoItemC.ToDoId);
            testToDo.StoreUppdatedObject(iToDoItemD, iToDoItemD.ToDoId);


            ToDo[] foundAllUpdatedAfter = testToDo.FindAllToDoItems(); // After test

            ToDo[] foundAlltrue = testToDo.FindByDoneStatus(true);
            ToDo[] foundAllfalse = testToDo.FindByDoneStatus(false);

            ToDo[] foundAssigneeIDA = testToDo.FindByAssignee(iPersonA.PersonId);
            ToDo[] foundAssigneeIDB = testToDo.FindByAssignee(iPersonD.PersonId);

            ToDo[] foundAssigneeA = testToDo.FindByAssignee(iPersonA);
            ToDo[] foundAssigneeB = testToDo.FindByAssignee(iPersonD);

            ToDo[] foundUnassItems = testToDo.FindUnassignedTodoItems();


            //Assert
            Assert.Equal(foundAllUpdatedBefore, foundAllUpdatedAfter); // getting the TodoItems-array with updated objects to see
                                                                  // in the debug with breakline, the stored info

            Assert.Contains(iToDoItemA, foundAlltrue);
            Assert.Contains(iToDoItemD, foundAllfalse);

            Assert.NotEqual(foundAssigneeIDB, foundAssigneeIDA);

            Assert.NotEqual(foundAssigneeB, foundAssigneeA);

            Assert.NotNull(foundUnassItems);

        }


        [Fact]
        public void TodoItemsClassTestingStep11()  // testing to remove a TodoItems-object from TodoItems-array,
                                                   // by finding array-index of that object.
                                                   // Then rebuild and resize TodoItems-array excluding that
                                                   // object on the found index. Going from 4 to 3 objects in this test.
                                                   // and checking with a test error, Assert.Equal to see what is stored.
                                                   
        {
            //Arrange
            string descriptionA = "Städa garaget";
            string descriptionB = "Diska";
            string descriptionC = "Köpa mjölk";
            string descriptionD = "Boka vaccinstid";

            TodoItems testTodoItems = new TodoItems();

            //Act ------------ Fill array with 4 objects to manipulate with
            TodoSequencer.ToDoReset();

            ToDo iToDoItemA = testTodoItems.CreateNewTodoToArray(descriptionA);
            ToDo iToDoItemB = testTodoItems.CreateNewTodoToArray(descriptionB);
            ToDo iToDoItemC = testTodoItems.CreateNewTodoToArray(descriptionC);
            ToDo iToDoItemD = testTodoItems.CreateNewTodoToArray(descriptionD);


            //Assert
            Assert.Equal(testTodoItems.RemoveOneToDoItemRebuildArray(iToDoItemC), testTodoItems.FindAllToDoItems());

            // Assert.Equal is meant to fail by design, to see BEFORE and AFTER 1 object was removed.

            // testTodoItems.RemoveOneToDoItemRebuildArray(iToDoItemC) RETURNS a copy of _arrOfTodoObjects BEFORE
            // removing 1 object in _arrOfTodoObjects. To be able to correctly check BEFORE and AFTER results.

            // I ask here above, for whole array _arrOfTodoObjects // with FindAllToDoItems() AFTER 1 object is removed.
            // 


        }

    }

}
