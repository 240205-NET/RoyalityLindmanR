using System;
using Xunit;
using RockPaperScissors;
using System.Reflection.Metadata;
using System.Security;

namespace RockPaperScissors.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CheckToStringType()
        {
            //Arrange
            User newUser = new User("test dummy");

            //Act

            //Assert
            Assert.IsType<string>(newUser.toString());
        }

        [Fact]
        public void CheckCpuChoiceType()
        {
            //Arrange
            Cpu computer = new Cpu();

            //Act

            //Assert
            Assert.IsType<int>(computer.playGame());
        }

        [Fact]
        public void CheckCpuChoiceNumber()
        {
            //Arrange
            Cpu computer = new Cpu();

            //Act

            //Assert
            Assert.InRange<int>(computer.playGame(), 1, 3);
        }

        [Fact]
        public void UserNotNull()
        {
            //Arrange
            User newUser = new User("test dummy");

            //Act

            //Assert
            Assert.NotNull(newUser);
        }
        [Fact]
        public void CpuNotNull()
        {
            //Arrange
            Cpu computer = new Cpu();

            //Act

            //Assert
            Assert.NotNull(computer);
        }

        [Fact]
        public void GameNotNull()
        {
            //Arrange
            Game game = new Game();

            //Act

            //Assert
            Assert.NotNull(game);
        }
        
         [Fact]
        public void CheckPlayerOptionsType()
        {
            //Arrange
            User newUser = new User("test dummy");

            //Act

            //Assert
            Assert.IsType<int>(newUser.playGame(1));
        }
         
         [Fact]
        public void CheckPlayerOptions1()
        {
            //Arrange
            User newUser = new User("test dummy");
            int test = 1;

            //Act
            int result = newUser.playGame(test);


            //Assert
            Assert.Equal(test, result);
        }
         
         [Fact]
        public void CheckPlayerOptions2()
        {
            //Arrange
            User newUser = new User("test dummy");
            int test = 2;

            //Act
            int result = newUser.playGame(test);


            //Assert
            Assert.Equal(test, result);
        } 
        
        [Fact]
        public void CheckPlayerOptions3()
        {
            //Arrange
            User newUser = new User("test dummy");
            int test = 3;

            //Act
            int result = newUser.playGame(test);


            //Assert
            Assert.Equal(test, result);
        }

    }
}

