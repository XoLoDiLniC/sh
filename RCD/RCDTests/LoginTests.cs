using Microsoft.VisualStudio.TestTools.UnitTesting;
using RCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCD.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void LoginingTest()
        {
            string password = "12343";
            string email = "maxim2003@mail.ru";
            bool expected =true;

            bool actual = password.Equals(expected);

            Assert.IsTrue(actual);

            Entities1.GetContext().Usersses.Any(p => p.Login == email && p.Password == password);
        }
    }
}