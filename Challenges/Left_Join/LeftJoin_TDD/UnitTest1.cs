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
            testLeft.Add("fond", "enamored");
            testLeft.Add("diligent", "employed");

            Hashtable testRight = new Hashtable(50);
            testRight.Add("fond", "averse");
            testRight.Add("flow", "jam");
            //{ [ ["fond", "enamored", "averse"], [] ] };
            List<object> expected = new List<object>(); 
            object[] left1 = new object[] { "fond", "enamored", "averse" };
            object[] left2 = new object[] { "diligent", "employed", NULL };
            expected.Add(left1);
            expected.Add(left2);
            Assert.Equal(expected, Program.LeftJoin(testLeft, testRight));
        }
    }
}
