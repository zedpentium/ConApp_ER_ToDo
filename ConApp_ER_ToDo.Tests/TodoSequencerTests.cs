using System;
using System.Collections.Generic;
using Xunit;
using ConApp_ER_ToDo.Data;

namespace ConApp_ER_ToDo.Tests
{
    public class TodoSequencerTests
    {


        [Fact]
        public void PersonSequencerClassTest()
        {
            //Arrange


            //Act
            int personIDfirst = TodoSequencer.NextToDoId(7);
            int personIDsecond = TodoSequencer.NextToDoId(11);
            int personIDthird = TodoSequencer.NextToDoId(56);

            //Assert
            Assert.Equal(8, personIDfirst);
            Assert.Equal(12, personIDsecond);
            Assert.Equal(57, personIDthird);
            Assert.Equal(7, personIDfirst);

        }


    }




}
