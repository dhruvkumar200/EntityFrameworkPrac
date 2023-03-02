using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkPrac.Models;
using EntityFrameworkPrac.Entities;

namespace EntityFrameworkPrac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    //     var model = new List<EmployeeDetails>();

    // model.Add(new EmployeeDetails { Name = "Dhruv",Age = 21,salary = "15000",Designation = ".Net"});
    // model.Add(new EmployeeDetails{ Name = "Rahul",Age = 21,salary = "15000",Designation = ".Net"});
    // model.Add(new EmployeeDetails{ Name = "janak", Age = 22,salary = "16000",Designation = "React"});


    // return View(model);

     using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
             return View(employeeList);
        }
      
    }

    public IActionResult Privacy()
    {
        return View();
    }
       public IActionResult Employee()
    {
        using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmployeeDetails.ToList();
            // var emplist=context.Forms.Where(x=>x.EmpId==3).FirstOrDefault();
        }
        return View();
    }
        public IActionResult AddEmployee(EmployeeModel employeeModel)
    {
        using (var context=new EmployeeDBContext())
        {
            EmployeeModel employee=new EmployeeModel();
            // employee.FirstName=employeeModel.FirstName;
            // employee.Name=employeeModel.Name;
            employee.Email=employeeModel.Email;
            employee.Password=employeeModel.Password;
            // employee.ConfirmPassword=employee.ConfirmPassword;
            // employee.Contact=employeeModel.Contact;
            // context.Forms.Add(employee);
            // context.SaveChanges();
         
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        // return View();
    }
    //   public IActionResult Employeelist()
    // {
    //     using (var context=new EmployeeDBContext())
    //     {
    //         var employeeList=context.EmployeeDetails.ToList();
    //          return View(employeeList);
    //     }
        
    // }
    [HttpPost]
public IActionResult Afterlogin()
{
    //handle your search stuff here...
    return RedirectToAction("Index", "Home");
}
     
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
