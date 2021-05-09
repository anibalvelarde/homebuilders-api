using System;

namespace api.domain.models
{
    public class Employee
    {
        public Employee()
        {
            Id = Guid.Empty;
            CreatedOn = DateTime.MinValue;
        }
        public Employee(Employee newHire)
        {
            if (newHire.Id.Equals(Guid.Empty) && newHire.CreatedOn.Equals(DateTime.MinValue))
            {
                Id = Guid.NewGuid();
                Name = newHire.Name;
                Email = newHire.Email;
                Role = newHire.Role;
                CreatedOn = DateTime.UtcNow;
            }
            else
            {
                throw new InvalidOperationException($"Employee instance is not a new hire. ID: {newHire.Id}");
            }
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Enums.EmployeeRole Role { get; set; }
        public DateTime CreatedOn { get; private set; }
    }
}