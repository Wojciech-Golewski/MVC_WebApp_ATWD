using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_WebApp_ATWD.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is a default action.";
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method.";
        }
        
    }
}
