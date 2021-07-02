using System;
using Xunit;
using ConApp_ER_ToDo.Data;
using ConApp_ER_ToDo.Model;


namespace ConApp_ER_ToDo.Tests
{
    public class PeopleTests
    {


        [Fact]
        public void PeopleClassTesting()
        {
            //Arrange
            string firstNameA = "Eric";
            string lastNameA = "Rönnhult";
            string firstNameB = "Tomas";
            string lastNameB = "Nilsson";
            string firstNameC = "Mattias";
            string lastNameC = "Bertilsson";
            string firstNameD = "Bernt";
            string lastNameD = "Jonsson";

            People testPeople = new People();

            //Act
            testPeople.Clear();

            Person iPersonA = testPeople.CreateNewPersonToArray(firstNameA, lastNameA);
            Person iPersonB = testPeople.CreateNewPersonToArray(firstNameB, lastNameB);
            Person iPersonC = testPeople.CreateNewPersonToArray(firstNameC, lastNameC);
            Person iPersonD = testPeople.CreateNewPersonToArray(firstNameD, lastNameD);

            Person foundById = testPeople.FindById(3);

            Person[] foundAllOne = testPeople.FindAll();
            Person[] foundAllTwo = testPeople.FindAll();


            //Assert
            Assert.Equal(firstNameA, iPersonA.FirstName);
            Assert.Equal(firstNameB, iPersonB.FirstName);
            Assert.Equal(lastNameC, iPersonC.LastName);
            Assert.Equal(lastNameD, iPersonD.LastName);
            Assert.Equal(1, iPersonA.PersonId);
            Assert.Equal(4, iPersonD.PersonId);

            Assert.NotEqual(lastNameB, iPersonD.LastName);
            Assert.NotEqual(iPersonA.PersonId, iPersonC.PersonId);

            Assert.Equal(iPersonC, foundById);
            Assert.NotEqual(iPersonB, foundById);

            Assert.Equal(foundAllOne, foundAllTwo);


        }

 




    }

}
