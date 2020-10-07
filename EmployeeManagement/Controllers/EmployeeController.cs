using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        List<Employee> employee =new List<Employee>();
        var employee1= new Employee
        {
            FirstName="Bishnu",
            SurName="Rawal",
            Address="Ktm",
            Salary=100.0;
        }
        return View();

    }
}
public class Employee 
{
    public string FirstName{get;set;}
    public string SurName{get;set;}
    public string Address{get;set;}
    public char Gender{get;set;}
    public doubles Salary{get;set;}
}