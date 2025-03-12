using DemoRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazor.Pages
{
    public class EmployeeModel : PageModel
    {
        public List<EmployeeData> Employees { get; set; }

        public List<EmployeeData> newEmp {  get; set; }
        public void OnGet()
        {
            List<EmployeeData> employees = new List<EmployeeData>();

            EmployeeData emp1 = new EmployeeData(1, "John", 24 );
            EmployeeData emp2 = new EmployeeData(2, "Sata", 22 );
            EmployeeData emp3 = new EmployeeData(3, "John", 30 );
            EmployeeData emp4 = new EmployeeData(4, "John", 44 );

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            Employees = employees;


        }

        


    }
}
