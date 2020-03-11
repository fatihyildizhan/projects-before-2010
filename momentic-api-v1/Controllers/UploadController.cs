using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace vs2015webapi.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        /*
        [HttpPost]
        public List<string> Upload()
        {
            List<string> names = new List<string>();
            // HttpResponseMessage result = null;
            try
            {
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        string name = Guid.NewGuid().ToString().Substring(0, 20) + ".jpeg";
                        var postedFile = httpRequest.Files[file];
                        var filePath = HttpContext.Current.Server.MapPath("~/Content/images/" + name);
                        postedFile.SaveAs(filePath);

                        names.Add(name);
                    }
                    // result = Request.CreateResponse(HttpStatusCode.Created);
                }
                else
                {
                    return names;
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return names;
        }
        */
    }
}
