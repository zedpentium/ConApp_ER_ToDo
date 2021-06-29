using System;
using System.Collections.Generic;
using Xunit;
using ConApp_ER_ToDo.Data;

namespace ConApp_ER_ToDo.Data.Tests
{
    public class PersonSequencerTests
    {


        [Fact]
        public void PersonSequencerClassTest()
        {
            //Arrange
            PersonSequencer.NextPersonId(7);

            //Act

            //Assert
            Assert.Equal(8, PersonSequencer.PersonId);

        }

        [Fact]
        public void PersonIdTest()
        {
            //Arrange
            PersonSequencer.NextPersonId(3);

            //Act
            PersonSequencer.Reset();


            //Assert

            
            Assert.Equal(0, PersonSequencer.PersonId);
            

        }








    }




}
