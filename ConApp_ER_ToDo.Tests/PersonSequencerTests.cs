using System;
using Xunit;
using ConApp_ER_ToDo.Data;

namespace ConApp_ER_ToDo.Tests
{
    public class PersonSequencerTests
    {


        [Fact]
        public void PersonSequencerClassTest()
        {
            //Arrange
            PersonSequencer.Reset();

            //Act
            int personIDfirst = PersonSequencer.NextPersonId();
            int personIDsecond = PersonSequencer.NextPersonId();
            int personIDthird = PersonSequencer.NextPersonId();

            //Assert
            Assert.Equal(1, personIDfirst);
            Assert.Equal(2, personIDsecond);
            Assert.Equal(3, personIDthird);
            Assert.NotEqual(0, personIDfirst);

        }



    }




}
