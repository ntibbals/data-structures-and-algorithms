using System;
using Xunit;
using Left_Join;
using Hashtables.Classes;
using System.Collections.Generic;

namespace LeftJoin_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestLeftJoin()
        {
            Hashtable testLeft = new Hashtable(50);
            testLeft.Add("shark", "kill");
            testLeft.Add("dolphin", "dance");

            Hashtable testRight = new Hashtable(50);
            testRight.Add("shark", "hunt");
            testRight.Add("whale", "jam");
            //{ [ ["fond", "enamored", "averse"], [] ] };
            List<object> expected = new List<object>(); 
            object[] left1 = new object[] { "shark", "kill", "hunt" };
            object[] left2 = new object[] { "dolphin", "dance", "NULL" };
            expected.Add(left2);
            expected.Add(left1);
            Assert.Equal(expected, Program.LeftJoin(testLeft, testRight));
        }

        [Fact]
        public void TestLeftJoinCollision()
        {
            Hashtable testLeft = new Hashtable(5);
            testLeft.Add("fond", "enamored");
            testLeft.Add("diligent", "employed");

            Hashtable testRight = new Hashtable(5);
            testRight.Add("fond", "averse");
            testRight.Add("flow", "jam");
            List<object> expected = new List<object>();
            object[] left1 = new object[] { "fond", "enamored", "averse" };
            object[] left2 = new object[] { "diligent", "employed", "NULL" };
            expected.Add(left2);
            expected.Add(left1);
            Assert.Equal(expected, Program.LeftJoin(testLeft, testRight));
        }
        [Fact]
        public void TestEmptyHashTable()
        {
            Hashtable testLeft = new Hashtable(50);
            Hashtable testRight = new Hashtable(50);
            List<object> expected = new List<object>();
            Assert.Equal(expected, Program.LeftJoin(testLeft, testRight));
        }
        [Fact]
        public void TestLeftNoCollision()
        {
            Hashtable testLeft = new Hashtable(50);
            testLeft.Add("fond", "enamored");
            testLeft.Add("diligent", "employed");

            Hashtable testRight = new Hashtable(50);
            testRight.Add("delightful", "averse");
            testRight.Add("empowered", "jam");
            List<object> expected = new List<object>();
            object[] left1 = new object[] { "fond", "enamored", "NULL" };
            object[] left2 = new object[] { "diligent", "employed", "NULL" };
            expected.Add(left2);
            expected.Add(left1);
            Assert.Equal(expected, Program.LeftJoin(testLeft, testRight));
        }
    }
}
