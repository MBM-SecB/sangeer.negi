using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController:  Controller
{
    
    public ViewResult First()
    {
        // State Management
        // 1. Client Side
            // 1.1 Cookies
            var name  = "Azyt Pandey";
            Response.Cookies.Append("user", name);

            // 2. Server Side
                // 2.1 Session
                HttpContext.Session.SetString("Address", "Kathmandu");
                



            return  View();

    }

    public ViewResult Second(string name,int age) //1.2 Query Strings
    {

        var userAddress = HttpContext.Session.GetString("Address");

            // 2.2 Temp Data
            TempData["CollegeName"] = "MBMC";

        
        return View();
    }


    public ViewResult Third() //1.2 Query Strings
    {

            // 2.2 Temp Data
            var cName = TempData["CollegeName"] = "MBMC";

            byte value = 67;

            ViewData["Name1"] = "abc from View Data";
            ViewBag.Name  = "abc from ViewBag";

        
        return View(value);
    }



    [HttpPost]
    public string Second(string collegeName) //1.3 Hidden Fields
    {
        
        return collegeName;
    }

}