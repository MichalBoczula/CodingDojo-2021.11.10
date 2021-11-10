using Interview;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ThirdTaskTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int[] array = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(6);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            int[] array = { };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(0);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            int[] array = { 1, 3, 2 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(3);
        }

        [Fact]
        public void Test4()
        {
            //arrange
            int[] array = { 5, 4, 3, 2, 1, 2, 10, 12 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(0);
        }

        [Fact]
        public void Test5()
        {
            //arrange
            int[] array = { 1, 1, 3, 2, 1 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(4);
        }

        [Fact]
        public void Test6()
        {
            //arrange
            int[] array = { 1, 1, 1, 2, 3, 10, 12, -3, -3, 2, 3, 45, 800, 99, 98, 0, -1, -1, 2, 3, 4, 5, 0, -1, -1 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(9);
        }

        [Fact]
        public void Test7()
        {
            //arrange
            int[] array = { 1, 2, 3, 3, 2, 1 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(0);
        }

        [Fact]
        public void Test8()
        {
            //arrange
            int[] array = { 5, 4, 3, 2, 1, 2, 10, 12, -3, 5, 6, 7, 10 };

            var thirdTask = new ThirdTask()
            {
                Nums = array
            };

            var codingDojo = new CodingDojo();

            //act
            var result = codingDojo.Third(thirdTask);

            //assert
            result.ShouldBe(5);
        }
    }
}
