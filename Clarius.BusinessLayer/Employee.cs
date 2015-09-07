using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Clarius.BusinessLayer
{
    public class Employee
    {
        [Key]
        public string EmployeeNo { get; set; } // 32
        public string Description { get; set; } // 62
        public string CommonName { get; set; } // 30
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; } // 100
        public DateTime DateEmployed { get; set; }
        public DateTime DateTerminated { get; set; }
        public string ReasonSuspension { get; set; } // 32
        public string ReasonTermination { get; set; } // 32
        public string Occupation { get; set; } // 32
        public short EmployeeStatus { get; set; }
        public short Class { get; set; }
        public decimal RateOfPay { get; set; }
        public decimal NetPay { get; set; }

        //public int Age { get; set; }
    }

    public class ClariusContex : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}