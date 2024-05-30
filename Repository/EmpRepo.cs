using DBFirstEg.Models;

namespace DBFirstEg.Repository
{
    public class EmpRepo : IEmpRepo<Employee>
    {
        private readonly FisbankDbContext _db;

        public EmpRepo(FisbankDbContext db)
        {
            _db = db;
        }
        public Employee AddEmployee(Employee e)
        {
            _db.Employees.Add(e);
            _db.SaveChanges();
            return e;
        }

        public void DeleteEmployee(int id)
        {
            var emp = _db.Employees.Find(id);
            _db.Employees.Remove(emp);
            _db.SaveChanges(true);
        }

        public List<Employee> getAllEmployes()
        {
            return (_db.Employees.ToList());
        }

        public List<Department> getDeparments()
        {
            var depts = _db.Departments.ToList();
            return depts;
        }

        public Employee getEmployeeById(int id)
        {
            var emp = _db.Employees.Find(id);
            return emp;
        }

        public Employee UpdateEmployee(int id, Employee e)
        {
            var emp = _db.Employees.Find(id);
            _db.Employees.Update(emp);
            _db.SaveChanges(true);
            return e;
        }
    }
}
