using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Dynamic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace vs2015webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        /*
        // GET: api/values
        public async Task<object> checkemail([FromBody] PersonEmail email)
        {
            bool flag = isEmail(email.email);
            dynamic cResponse = new ExpandoObject();

            if (!string.IsNullOrEmpty(email.email) && flag)
            {
                var database = DBHelper.ConnectMongoAWS();
                //var collection = database.GetCollection<PersonViewModel>("People");

                var collection = await database.GetCollection<PersonViewModel>("People").Find(p => p.email == email.email);
                //PersonViewModel found = await collection.Find(new BsonDocument("email", email.ToBson())).ToBsonDocument();

            //    var filter = Builders<BsonDocument>.Filter.Eq("email", email.email);
            //    var result = await collection.Find(filter).Singles
                
                int count = 1;//await db.Person.CountAsync(x => x.Email == email.Email);

                if (count > 0)
                {
                    cResponse.Result = "-1";
                    cResponse.Description = "Email is not available";
                    cResponse.Email = email.email;
                    return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
                }
                else
                {
                    cResponse.Result = "0";
                    cResponse.Description = "Email is available";
                    cResponse.Email = email.email;
                    return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
                }
            }
            else
            {
                cResponse.Result = "-1";
                cResponse.Description = "Email format is wrong";
                cResponse.Email = email.email;
                return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
            }
        }

        private bool isEmail(string inputEmail)
        {
            Regex re = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$",RegexOptions.IgnoreCase);
            return re.IsMatch(inputEmail);
        }
        */
    }
}
