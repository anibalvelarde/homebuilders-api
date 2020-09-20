using System;

namespace HomeBuilders.Api.Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Enums.EmployeeRole Role { get; set; }
    }
}