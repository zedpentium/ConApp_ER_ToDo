using System;
using Xunit;
using ConApp_ER_ToDo.Model;

namespace ConApp_ER_ToDo.Tests
{
    public class PersonTests
    {
        

        [Fact]
        public void PersonClassTest()
        {
            //Arrange
            string firstName = "Eric";
            string lastName = "Rönnhult";
            string firstName2 = "Tomas";
            string lastName2 = "Lindberg";

            //Act
            Person person1 = new Person(firstName, lastName, 1);
            Person person2 = new Person(firstName2, lastName2, 2);

            //Assert
            //Assert.NotEqual(person1.PersonId, person2.PersonId);
            Assert.Equal(person2, person2);
            Assert.NotEqual(person1, person2);
            Assert.NotEqual(2, person1.PersonId);

        }



    }
}
