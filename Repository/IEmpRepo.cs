using DBFirstEg.Models;

namespace DBFirstEg.Repository
{
    public interface IEmpRepo<Employee>
    {
        public List<Employee> getAllEmployes();
        public Employee getEmployeeById(int id);
        public Employee AddEmployee(Employee e);
        public Employee UpdateEmployee(int id, Employee e);
        public void DeleteEmployee(int id);

        public List<Department> getDeparments();
    }
}

