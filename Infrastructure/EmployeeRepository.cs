using Application;
using Domain;
using System;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee Get(string userId)
        {
            // 假設以下資料來自 Database
            // 但由於單元測試不希望被資料庫綁住，因此 Fake 整個 Repositories （採用手刻假物件方式）
            return new Employee()
            {
                AID = "F123456789",
                UserID = "gelis.wu"
            };
        }
    }
}
