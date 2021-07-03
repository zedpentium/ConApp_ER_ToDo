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

            /*string firstNameC = "Mattias";
            string lastNameC = "Bertilsson";
            string firstNameD = "Bernt";
            string lastNameD = "Jonsson";*/

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

            ToDo[] foundAllUpdatedOne = testToDo.FindAllToDoItems(); // running theese 2 tests to see if Done status and Assignee
            ToDo[] foundAllUpdatedTwo = testToDo.FindAllToDoItems(); // have been properly set and stored in the ToDoItems array.

            ToDo[] foundAlltrue = testToDo.FindByDoneStatus(true);
            ToDo[] foundAllfalse = testToDo.FindByDoneStatus(false);

            ToDo[] foundAssigneeIDA = testToDo.FindByAssignee(iPersonA.PersonId);
            ToDo[] foundAssigneeIDB = testToDo.FindByAssignee(iPersonD.PersonId);

            ToDo[] foundAssigneeA = testToDo.FindByAssignee(iPersonA);
            ToDo[] foundAssigneeB = testToDo.FindByAssignee(iPersonD);

            ToDo[] foundUnassItems = testToDo.FindUnassignedTodoItems();


            //Assert
            Assert.Equal(foundAllUpdatedOne, foundAllUpdatedTwo); // getting the ToDoItems-array with updated objects to see
                                                                  // in the debug with breakline, the stored info

            Assert.Contains(iToDoItemA, foundAlltrue);
            Assert.Contains(iToDoItemD, foundAllfalse);

            Assert.NotEqual(foundAssigneeIDB, foundAssigneeIDA);

            Assert.NotEqual(foundAssigneeB, foundAssigneeA);

            Assert.NotNull(foundUnassItems);

        }



    }

}
