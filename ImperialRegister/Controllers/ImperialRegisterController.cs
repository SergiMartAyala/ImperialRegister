using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ImperialRegister.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImperialRegisterController : Controller
    {

        private readonly ILogger<ImperialRegisterController> _logger;
        private string docPath = "E:/Repos/ImperialRegister/";

        public ImperialRegisterController(ILogger<ImperialRegisterController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult GetResult([FromForm] ImperialRegisterDeclaration postinformation)
        {
            try
            {
                foreach (var information in postinformation.InformationDetails)
                {

                    string name = information.Name;
                    string planet = information.Planet;
                    DateTime date = new DateTime();
                    string entry = "rebel " + name + " on " + planet + " at " + date;

                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "SaveNames.txt")))
                    {
                        outputFile.WriteLine(entry);
                    }
                }
                
            }
            catch {
                Console.WriteLine("Error at saving names ");
            }
            return Json(postinformation);
        }
    }
}
