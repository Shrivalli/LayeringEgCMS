using DBFirstEg.Models;
using DBFirstEg.Repository;

namespace DBFirstEg.Service
{
    public class EmpServ : IEmpServ<Employee>
    {

        private readonly IEmpRepo<Employee> _emprepo;

        public EmpServ(IEmpRepo<Employee> emprepo)
        {
            _emprepo = emprepo;
        }
        public Employee AddEmployee(Employee e)
        {
           _emprepo.AddEmployee(e);
            return e;
        }

        public void DeleteEmployee(int id)
        {
            _emprepo.DeleteEmployee(id);
        }

        public List<Employee> getAllEmployes()
        {
            return (_emprepo.getAllEmployes());

        }

        public List<Department> getDeparments()
        {
            return _emprepo.getDeparments();
        }

        public Employee getEmployeeById(int id)
        {
           return _emprepo.getEmployeeById(id);
        }

        public Employee UpdateEmployee(int id, Employee e)
        {
            return _emprepo.UpdateEmployee(id, e);
        }
    }
}
