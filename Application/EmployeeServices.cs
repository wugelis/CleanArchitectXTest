using Domain;
using System;

namespace Application
{
    public class EmployeeServices
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        /// <summary>
        /// 套用身分別
        /// </summary>
        /// <param name="userId"></param>
        public void ApplySettings(string userId)
        {
            // Get a Employee
            Employee emp = _employeeRepository.Get(userId);

            // Check is VIP
            bool result = emp.CheckIsAID();
        }
    }
}
