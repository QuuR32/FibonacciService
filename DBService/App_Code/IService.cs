using System.Collections.Generic;
using System.Data.Entity;
using System.ServiceModel;
using System.Threading.Tasks;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    string GetString();

    [OperationContract]
    List<Employees> GetEmployees();

    [OperationContract]
    EmployeesDetails GetEmployeeDetails(int id);

    [OperationContract]
    List<Departments> GetDepartments();

    [OperationContract]
    Departments GetDepartment(int id);

    [OperationContract]
    int SaveEmployee(Employees employee);

    [OperationContract]
    int SaveDepartment(Departments department);
}