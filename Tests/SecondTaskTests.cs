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
    public class SecondTaskTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            string[] Cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "CANNAS"
            };

            var second = new SecondTask()
            {
                Cities = Cities
            };
            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "A: AMSTERDAM",
                "C: CANNAS",
                "L: LONDON",
                "N: NEW DELHI",
                "P: PARIS",
                "R: ROME",
                "Z: ZURICH"
            };

            //act
            var result = codingDojo.Second(second).ToList();

            //assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            string[] Cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "CANNAS",
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS", "CANNAS"
            };

            var second = new SecondTask()
            {
                Cities = Cities
            };
            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "A: AMSTERDAM",
                "C: CANNAS",
                "L: LONDON",
                "N: NEW DELHI",
                "P: PARIS",
                "R: ROME",
                "Z: ZURICH"
            };

            //act
            var result = codingDojo.Second(second).ToList();

            //assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            string[] Cities =
            {

            };

            var second = new SecondTask()
            {
                Cities = Cities
            };
            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {

            };

            //act
            var result = codingDojo.Second(second).ToList();

            //assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test4()
        {
            //arrange
            string[] Cities =
            {
                "aa", "aaa", "ab", "ac", "bb", "bd", "z", "zzz", "zz", "az", "c", "cc",
                "cz", "z", "dd", "ccc", "efd", "ff", "fd", "fa", "fc", "efde", "efe"
            };

            var second = new SecondTask()
            {
                Cities = Cities
            };
            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "a: az",
                "b: bd",
                "c: cz",
                "d: dd",
                "e: efe",
                "f: ff",
                "z: zzz"
            };

            //act
            var result = codingDojo.Second(second).ToList();

            //assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Test5()
        {
            //arrange
            string[] Cities =
            {
                "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa",
                "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa"
            };

            var second = new SecondTask()
            {
                Cities = Cities
            };
            var codingDojo = new CodingDojo();

            var expected = new List<string>()
            {
                "a: aaaaaaaaa"
            };

            //act
            var result = codingDojo.Second(second).ToList();

            //assert
            result.ShouldBe(expected);
        }


    }
}
