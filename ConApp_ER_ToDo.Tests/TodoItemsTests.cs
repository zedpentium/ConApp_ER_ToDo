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

 




    }

}
