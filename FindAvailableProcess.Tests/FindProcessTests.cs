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
            bool result = FindProcess.IsProcessRunning("yandex");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestProcessIsNotRunning()
        {
            bool result = FindProcess.IsProcessRunning("devenv");
            Assert.IsFalse(result);
        }
    }
}
