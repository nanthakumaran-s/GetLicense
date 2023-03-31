using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Test1()
        {
            Assert.IsTrue(Program.GetLicense("Eric", 2, "Adam Caroline Rebecca Frank") == 40);
        }

        [TestMethod()]
        public void Test2()
        {
            Assert.IsTrue(Program.GetLicense("Zebediah", 1, "Bob Jim Becky Pat") == 100);
        }

        [TestMethod()]
        public void Test3()
        {
            Assert.IsTrue(Program.GetLicense("Aaron", 3, "Jane Max Olivia Sam") == 20);
        }
    }
}