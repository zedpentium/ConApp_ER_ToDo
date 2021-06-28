using ConApp_ER_ToDo.Model;
using System;
using Xunit;

namespace ConApp_ER_ToDo.Model.Tests
{
    public class PersonTests
    {
        

        [Fact]
        public void PersonClassTest()
        {
            //Arrange
            string firstName = "Kent";
            string lastName = "Svensson";
            string firstName2 = "Test";
            string lastName2 = "Testsson";

            //Act
            Person person1 = new Person(firstName, lastName);
            Person person2 = new Person(firstName2, lastName2);

            //Assert
            Assert.NotEqual(person1.pubPersonId, person2.pubPersonId);
            Assert.Equal(person2, person2);
            Assert.NotEqual(person1, person2);

            //Console.WriteLine($"Output: {person1} { person2}" );
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
