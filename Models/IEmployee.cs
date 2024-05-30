namespace DBFirstEg.Models
{
    public interface IEmployee<Employee>
    {
        public List<Employee> getAllEmployes();
        public Employee getEmployeeById(int id);
        public Employee AddEmployee(Employee e);
        public Employee UpdateEmployee(int id, Employee e);
        public void DeleteEmployee(int id);
    }
}
