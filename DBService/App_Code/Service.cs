// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
using System.Collections.Generic;
using System.Linq;

public class Service : IService
{
    private MSSQLLocalDBEntities mDbEntities;

    public MSSQLLocalDBEntities DbEntities {
        get {
            if (mDbEntities == null) {
                mDbEntities = new MSSQLLocalDBEntities();
            }

            return mDbEntities;
        }
    }

    public string GetString()
    {
        return "test";
    }

    public List<Employees> GetEmployees()
    {
        return DbEntities.Employees.ToList();
    }

    public EmployeesDetails GetEmployeeDetails(int id)
    {
        return DbEntities.EmployeesDetails.Where(e => e.Id == id).First();
    }

    public List<Departments> GetDepartments()
    {
        return DbEntities.Departments.ToList();
    }

    public Departments GetDepartment(int id)
    {
        return DbEntities.Departments.Where(d => d.Id == id).First();
    }

    public int SaveEmployee(Employees employee)
    {
        return DbEntities.Employee_Update(
            employee.Id, 
            employee.FirstName, 
            employee.LastName, 
            employee.Gender, 
            employee.EmployeesDetails.Salary, 
            employee.EmployeesDetails.DepartmentId, 
            employee.EmployeesDetails.JobTitle
            );
    }

    public int SaveDepartment(Departments department)
    {
        return DbEntities.Department_Update(
            department.Id,
            department.Name,
            department.Location
            );
    }
}
