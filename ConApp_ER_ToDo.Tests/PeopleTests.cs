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


        [Fact]
        public void PeopleClassTestingStep11()     // testing to remove a Person-object from _arrOfPersonObjects-array,
                                                   // by finding array-index of that object.
                                                   // Then rebuild and resize _arrOfPersonObjects-array excluding that
                                                   // object on the found index. Going from 4 to 3 objects in this test.
                                                   // and checking with a Assert.Equal test fail, to see what is stored.

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

            //Act ------------ Fill array with 4 objects to manipulate with
            testPeople.Clear();

            Person iPersonA = testPeople.CreateNewPersonToArray(firstNameA, lastNameA);
            Person iPersonB = testPeople.CreateNewPersonToArray(firstNameB, lastNameB);
            Person iPersonC = testPeople.CreateNewPersonToArray(firstNameC, lastNameC);
            Person iPersonD = testPeople.CreateNewPersonToArray(firstNameD, lastNameD);


            //Assert
            Assert.Equal(testPeople.RemoveOneToDoItemRebuildArray(iPersonC), testPeople.FindAll());

            // Assert.Equal is meant to fail by design, to see BEFORE and AFTER 1 object was removed.

            // testTodoItems.RemoveOneToDoItemRebuildArray(iToDoItemC) RETURNS a copy of _arrOfTodoObjects BEFORE
            // removing 1 object in _arrOfTodoObjects. To be able to correctly check BEFORE and AFTER results.

            // I ask here above, for whole array _arrOfTodoObjects // with FindAllToDoItems() AFTER 1 object is removed.
            // 


        }




    }

}
