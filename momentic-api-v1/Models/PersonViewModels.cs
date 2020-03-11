using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace vs2015webapi
{
    public class PersonViewModel
    {
        public ObjectId _id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string photoUrlLarge { get; set; }
        public string photoUrlThumbnail { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string about { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public DateTime lastLoginDate { get; set; }
        public SettingsViewModel settingsModel { get; set; }
        public List<DeviceViewModel> deviceList { get; set; }
        public List<FollowerViewModel> followerList { get; set; }
        public List<FollowerViewModel> followingList { get; set; }
    }

    public class FollowerViewModel
    {
        public ObjectId _id { get; set; }
        public string usernamePerson { get; set; }
        public string thumbnailPerson { get; set; }
        public string usernameFollower { get; set; }
        public string thumbnailFollower { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public bool doAccepted { get; set; }
    }

    public class SettingsViewModel
    {
        public string role { get; set; }
        public string code { get; set; }
        public bool doPrivate { get; set; }
        public bool doActive { get; set; }
        public bool doPushAllowed { get; set; }
        public bool doEmailAllowed { get; set; }
        public bool doSuspended { get; set; }
    }

    public class DeviceViewModel
    {
        public ObjectId _id { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public bool doActive { get; set; }
        public DateTime lastLoginDate { get; set; }
        public string deviceType { get; set; }
        public string deviceToken { get; set; }
        public string deviceOs { get; set; }
        public string osVersion { get; set; }
        public string appVersion { get; set; }
        public string language { get; set; }
    }
}
