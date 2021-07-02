using System;
using Xunit;
using ConApp_ER_ToDo.Model;

namespace ConApp_ER_ToDo.Tests
{
    public class ToDoTests
    {
        

        [Fact]
        public void ToDoClassTest()
        {
            //Arrange
            string description = "First Person duties";
            string description2 = "Second Person stuff to do";
            string description3 = "3rd Persons schedule";

            //Act
            ToDo person1 = new ToDo(3, description);
            ToDo person2 = new ToDo(6, description2);
            ToDo person3 = new ToDo(9, description3);

            //Assert
            Assert.Equal(person1.Description, person1.Description);
            Assert.Equal(person2.Description, person2.Description);
            Assert.Equal(person3.Description, person3.Description);
            Assert.NotEqual(person3.Description, person2.Description);
            Assert.NotEqual(person1.ToDoId, person2.ToDoId);
            Assert.NotEqual(person2.ToDoId, person3.ToDoId);
            Assert.Equal(person3.ToDoId, person3.ToDoId);

        }




    }
}
