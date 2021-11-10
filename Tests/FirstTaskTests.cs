using Interview;
using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class FirstTaskTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var firstNameList = new List<string>()
            {
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One"
            };

            var lastNameList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var ageList = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };

            var pesel = new List<int>()
            {
                111,
                222,
                333,
                444,
                555
            };

            var firstTask = new FirstTask()
            {
                FirstName = firstNameList,
                LastName = lastNameList,
                Age = ageList,
                Pesel = pesel
            };

            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "FirstName: Majk; LastName: A; Age: 1; Pesel: 111;",
                "FirstName: Junior; LastName: B; Age: 2; Pesel: 222;",
                "FirstName: Somebody; LastName: C; Age: 3; Pesel: 333;",
                "FirstName: Another; LastName: D; Age: 4; Pesel: 444;",
                "FirstName: One; LastName: E; Age: 5; Pesel: 555;"
            };

            //act
            var result = codingDojo.First(firstTask);
            
            //asset
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            var firstNameList = new List<string>()
            {
                "Majk",
                "Junior",
            };

            var lastNameList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var ageList = new List<int>()
            {
                1,
                2,
            };

            var pesel = new List<int>()
            {
                111,
                222,
                333,
            };

            var firstTask = new FirstTask()
            {
                FirstName = firstNameList,
                LastName = lastNameList,
                Age = ageList,
                Pesel = pesel
            };

            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "FirstName: Majk; LastName: A; Age: 1; Pesel: 111;",
                "FirstName: Junior; LastName: B; Age: 2; Pesel: 222;",
            };

            //act
            var result = codingDojo.First(firstTask);

            //asset
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            var firstNameList = new List<string>()
            {
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One",
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One",
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One"
            };

            var lastNameList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "A",
                "B",
                "C",
                "D",
                "E",
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var ageList = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                1,
                2,
                3,
                4,
                5,
                1,
                2,
                3,
                4,
                5
            };

            var pesel = new List<int>()
            {
                111,
                222,
                333,
                444,
                555,
                111,
                222,
                333,
                444,
                555,
                111,
                222,
                333,
                444,
                555
            };

            var firstTask = new FirstTask()
            {
                FirstName = firstNameList,
                LastName = lastNameList,
                Age = ageList,
                Pesel = pesel
            };

            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "FirstName: Majk; LastName: A; Age: 1; Pesel: 111;",
                "FirstName: Junior; LastName: B; Age: 2; Pesel: 222;",
                "FirstName: Somebody; LastName: C; Age: 3; Pesel: 333;",
                "FirstName: Another; LastName: D; Age: 4; Pesel: 444;",
                "FirstName: One; LastName: E; Age: 5; Pesel: 555;"
            };

            //act
            var result = codingDojo.First(firstTask);

            //asset
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test4()
        {
            //arrange
            var firstNameList = new List<string>()
            {
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One",
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One",
                "Majk",
                "Junior",
                "Somebody",
                "Another",
                "One"
            };

            var lastNameList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "A",
                "B",
                "C",
                "D",
                "E",
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var ageList = new List<int>()
            {
                1
            };

            var pesel = new List<int>()
            {
                111,
                222,
                333,
                444,
                555,
                111,
                222,
                333,
                444,
                555,
                111,
                222,
                333,
                444,
                555
            };

            var firstTask = new FirstTask()
            {
                FirstName = firstNameList,
                LastName = lastNameList,
                Age = ageList,
                Pesel = pesel
            };

            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "FirstName: Majk; LastName: A; Age: 1; Pesel: 111;"
            };

            //act
            var result = codingDojo.First(firstTask);

            //asset
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test5()
        {
            //arrange
            var firstNameList = new List<string>()
            {
                "Majk",
                "Junior",
            };

            var lastNameList = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var ageList = new List<int>()
            {

            };

            var pesel = new List<int>()
            {
                111,
                222,
                333,
            };

            var firstTask = new FirstTask()
            {
                FirstName = firstNameList,
                LastName = lastNameList,
                Age = ageList,
                Pesel = pesel
            };

            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                
            };

            //act
            var result = codingDojo.First(firstTask);

            //asset
            result.ShouldBe(expected);
        }
    }
}
