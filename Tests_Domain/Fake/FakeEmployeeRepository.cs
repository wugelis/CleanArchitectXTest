using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_Domain.Fake
{
    public class FakeEmployeeRepository : IEmployeeRepository
    {
        public Employee Get(string userId)
        {
            return new Employee()
            {
                AID = "F123456789",
                UserID = userId
            };
        }
    }
}
