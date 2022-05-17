using System;
using System.Text.RegularExpressions;

namespace Domain
{
    public class Employee
    {
        public string AID { get; set; }
        public string UserID { get; set; }

        public bool CheckIsAID()
        {
            return new Regex("^[A-Z]{1}[1-2]{1}[0-9]{8}$").IsMatch(AID);
        }
    }
}
