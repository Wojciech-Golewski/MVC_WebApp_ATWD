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
        public string Welcome(string name="user", int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Your ID is: {id}");
        }
        
    }
}
