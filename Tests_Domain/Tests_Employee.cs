using Xunit;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Tests_Domain.Fake;

namespace Domain.Tests
{
    public class Tests_Employee
    {
        [Fact()]
        public void Test_CheckIsAID()
        {
            // Arrange
            IEmployeeRepository source = new FakeEmployeeRepository();
            Employee target = source.Get("gelis");
            bool expected = true;
            bool actual;

            // Act
            actual = target.CheckIsAID();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}