using FluentAssertions;
using MinesweeperLibrary;
using NUnit.Framework;
using System;

namespace Tests
{

    [TestFixture]
    public class NunitTests
    {
        //Testing CheckPositionOnBoard method
        [Test]
        public void CheckPositionOnBoard_ItsNotMine_ShouldBe1()
        {
            var checkPosition = new CheckPosition();
            char[,] board = new char[,]
            {
                { '1','1','1'},
                { '1','M','1'},
                { '1','1','1'},


            };

            var result = checkPosition.CheckPositionOnBoard(1, 2, board);
            Assert.AreEqual(result, '1');

        }
        [Test]
        public void CheckPositionOnBoard_ItsMine_ShouldBeM()
        {
            var checkPosition = new CheckPosition();
            char[,] board = new char[,]
            {
                { '1','1','1'},
                { '1','M','1'},
                { '1','1','1'},


            };

            var result = checkPosition.CheckPositionOnBoard(1, 1, board);
            Assert.AreEqual(result, 'M');

        }
        [Test]
        public void CheckPositionOnBoard_InvalidPosition_Throw()
        {
            var checkPosition = new CheckPosition();
            char[,] board = new char[,]
            {
                { '1','1','1'},
                { '1','M','1'},
                { '1','1','1'},


            };
            Action test = () => checkPosition.CheckPositionOnBoard(8, 8, board);

            test.Should().Throw<Exception>();


        }


        //Testing DigShovel method
        [Test]
        public void DigAShovel_ItsMine_ShouldBeFalse()
        {
            var dig = new Dig();
            char[,] board = new char[,]
            {
                { '1','1','1'},
                { '1','M','1'},
                { '1','1','1'},


            };
            var result = dig.DigShovel(1, 1, board, 3);
            Assert.False(result);

        }
        [Test]
        public void DigAShovel_ItsNotMine_ShouldBeTrue()
        {
            var dig = new Dig();
            char[,] board = new char[,]
            {
                { '1','1','1'},
                { '1','M','1'},
                { '1','1','1'},


            };
            var result = dig.DigShovel(1, 0, board, 3);
            Assert.True(result);

        }

    }
}
