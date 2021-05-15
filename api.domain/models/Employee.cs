using System;

namespace api.domain.models
{
    /// <summary>
    /// Describes an employee who works for a Home Builder
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public Employee()
        {
            Id = Guid.Empty;
            CreatedOn = DateTime.MinValue;
        }

        /// <summary>
        /// Creates an instance of an employee based on a prospect/new-hire
        /// </summary>
        /// <param name="newHire"></param>
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

        /// <summary>
        /// Unique identifier
        /// </summary>
        /// <value></value>
        public Guid Id { get; private set; }
        /// <summary>
        /// Name of the employee
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Email for the employee
        /// </summary>
        /// <value></value>
        public string Email { get; set; }
        /// <summary>
        /// Describes in what capacity is an employee associated to a Home Builder
        /// </summary>
        /// <value></value>
        public Enums.EmployeeRole Role { get; set; }
        /// <summary>
        /// Date time stamp when the Employee information was created in the system
        /// </summary>
        /// <value></value>
        public DateTime CreatedOn { get; private set; }
    }
}