using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindAvailableProcess;

namespace FindAvailableProcess.Tests
{
    [TestClass]
    public class FindProcessTests
    {

        [TestMethod]
        public void TestProcessIsRunning()
        {
            Stub stub = new Stub();
            bool result = FindProcess.IsProcessRunning("yandex", stub);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestProcessIsNotRunning()
        {
            Stub stub = new Stub();
            bool result = FindProcess.IsProcessRunning("browser", stub);
            Assert.IsFalse(result);
        }
    }
}
