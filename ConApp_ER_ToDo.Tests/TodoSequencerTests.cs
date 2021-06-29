using System;
using System.Collections.Generic;
using Xunit;
using ConApp_ER_ToDo.Data;

namespace ConApp_ER_ToDo.Data.Tests
{
    public class TodoSequencerTests
    {


        [Fact]
        public void TodoSequencerClassTest()
        {
            //Arrange
            TodoSequencer.NextToDoId(7);

            //Act

            //Assert
            Assert.Equal(8, TodoSequencer.PersonId);

        }

        [Fact]
        public void ToDoIdTest()
        {
            //Arrange
            TodoSequencer.NextToDoId(3);

            //Act
            TodoSequencer.ToDoReset();


            //Assert

            
            Assert.Equal(0, TodoSequencer.PersonId);
            

        }








    }




}
