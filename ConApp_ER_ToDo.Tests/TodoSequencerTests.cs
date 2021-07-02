using System;
using Xunit;
using ConApp_ER_ToDo.Data;

namespace ConApp_ER_ToDo.Tests
{
    public class TodoSequencerTests
    {


        [Fact]
        public void TodoSequencerClassTest()
        {
            //Arrange
            TodoSequencer.ToDoReset();

            //Act
            int personIDfirst = TodoSequencer.NextToDoId();
            int personIDsecond = TodoSequencer.NextToDoId();
            int personIDthird = TodoSequencer.NextToDoId();

            //Assert
            Assert.Equal(1, personIDfirst);
            Assert.Equal(2, personIDsecond);
            Assert.Equal(3, personIDthird);
            Assert.NotEqual(0, personIDfirst);

        }


    }




}
