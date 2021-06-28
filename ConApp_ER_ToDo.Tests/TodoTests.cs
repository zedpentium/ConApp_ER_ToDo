using ConApp_ER_ToDo.Model;
using System;
using Xunit;

namespace ConApp_ER_ToDo.Model.Tests
{
    public class ToDoTests
    {
        

        [Fact]
        public void ToDoClassTest()
        {
            //Arrange
            //string firstName = "Kent";
            //string lastName = "Svensson";
            //int todoId = ToDo.PtodoId;

            string description = "First Person";
            string description2 = "Second Person";
            string description3 = "3rd Person";

            //Act
            ToDo person1 = new ToDo(3, description);
            ToDo person2 = new ToDo(6, description2);
            ToDo person3 = new ToDo(9, description3);

            //Assert
            //Assert.NotEqual(person1.personIdnr, person2.personIdnr);
            Assert.Equal(person1, person1);
            Assert.Equal(person2, person2);
            Assert.Equal(person3, person3);
            //Assert.NotEqual(person1, person2);

            Console.WriteLine($"Output: {person1} { person2}" );
        }


        [Fact]
        public void Testsomething()
        {

            //arrange



            //act



            //assert
        }


    }
}
