using System;
using Microsoft.AspNet.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Dynamic;
using Newtonsoft.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace vs2015webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PersonController : Controller
    {
        public async Task<object> insertUser([FromBody] PersonViewModel pm)
        {
            dynamic cResponse = new ExpandoObject();

            var database = DBHelper.ConnectMongoAWS();
            var collection = database.GetCollection<PersonViewModel>("People");

            PersonViewModel person = pm;
            try
            {
                person._id = ObjectId.GenerateNewId();
                person.createdOn = DateTime.Now;
                person.modifiedOn = DateTime.Now;
                person.lastLoginDate = DateTime.Now;
                person.photoUrlThumbnail = "http://momencraft.com/Content/PersonPhotos/p-momencraft.png"; // "ph213" + person.username + Guid.NewGuid().ToString() + ".png";
                person.photoUrlLarge = "http://momencraft.com/Content/PersonPhotos/p-momencraft.png"; //"ph231" + person.username + Guid.NewGuid().ToString() + ".png";

                // 2 adet isim olustur, resim degisse bile bu linkler sabit kalsin, boylece her kullanildigi yerde yeni resim olacak.

                SettingsViewModel settings = new SettingsViewModel();
                settings.code = Guid.NewGuid().ToString().Substring(0, 5);
                settings.doActive = false;
                settings.doEmailAllowed = true;
                settings.doPrivate = false;
                settings.doPushAllowed = true;
                settings.doSuspended = false;
                settings.role = "Holy Person";
                person.settingsModel = settings;

                FollowerViewModel following = new FollowerViewModel();
                following._id = ObjectId.GenerateNewId();
                following.createdOn = DateTime.Now;
                following.modifiedOn = DateTime.Now;
                following.doAccepted = true;
                following.usernamePerson = "momencraft";
                following.usernameFollower = person.username;
                following.thumbnailFollower = person.photoUrlThumbnail;
                following.thumbnailPerson = "http://momencraft.com/Content/PersonPhotos/p-momencraft.png";

                person.followingList = new System.Collections.Generic.List<FollowerViewModel>();

                person.followingList.Add(following);
                
                person.deviceList[0]._id = ObjectId.GenerateNewId();
                person.deviceList[0].createdOn = DateTime.Now;
                person.deviceList[0].modifiedOn = DateTime.Now;
                person.deviceList[0].lastLoginDate = DateTime.Now;
                person.deviceList[0].doActive = true;

                await collection.InsertOneAsync(person);

                cResponse.Result = "0";
                cResponse.data = person;
                cResponse.Token = person.email;
                return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
            }
            catch (Exception ex)
            {
                cResponse.Result = "-1";
                cResponse.exception = ex.Message;
                return JsonConvert.DeserializeObject(JsonConvert.SerializeObject(cResponse));
            }
        }

        public async void insertfollower(FollowerViewModel follow)
        {
            var client = new MongoClient("mongodb.com");
            var database = client.GetDatabase("AppDB");
            var collection = database.GetCollection<BsonDocument>("People");

            follow._id = ObjectId.GenerateNewId();
            follow.createdOn = DateTime.Now;
            follow.modifiedOn = DateTime.Now;
            follow.doAccepted = false;

            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("usernames", follow.usernamePerson);
                var update = Builders<BsonDocument>.Update.Push("followers", follow);
                UpdateResult result = await collection.UpdateOneAsync(filter, update);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
