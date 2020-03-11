using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using System.Dynamic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MongoDB.Bson;
using System;

namespace vs2015webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TimelineController : Controller
    {
        // GET: api/values
        public async void insertTimeline([FromBody] TimelineViewModel timeline)
        {
            var database = DBHelper.ConnectMongoAWS();
            var collection = database.GetCollection<TimelineViewModel>("newTimeline");

            TimelineViewModel time = timeline;
            try
            {
                time._id = ObjectId.GenerateNewId();
                time.createdOn = DateTime.Now;
                time.modifiedOn = DateTime.Now;
                time.doRetell = false;

                foreach (MomentViewModel item in time.momentList)
                {
                    item._id = ObjectId.GenerateNewId();
                    item.createdOn = DateTime.Now;
                    item.modifiedOn = DateTime.Now;
                }

                await collection.InsertOneAsync(time);
            }
            catch (Exception ex)
            {
            }
        }

        [HttpPost]
        public async Task<object> findPosts()
        {
            dynamic cResponse = new ExpandoObject();

            var database = DBHelper.ConnectMongoAWS();

            var collection = database.GetCollection<TimelineViewModel>("newTimeline");
            List<TimelineViewModel> list = await collection.Find(new BsonDocument()).ToListAsync();

            list.Reverse();

            cResponse.Result = "0";
            cResponse.data = list;
            return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
