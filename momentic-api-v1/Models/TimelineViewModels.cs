using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace vs2015webapi
{
    public class TimelineViewModel
    {
        public ObjectId _id { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public bool doRetell { get; set; }
        public string postedbyUsername { get; set; }
        public string postedbyThumbnail { get; set; }
        public string tellerUsername { get; set; }
        public string tellerThumbnail { get; set; }
        public int coverPhotoIndex { get; set; }
        public bool doPrivate { get; set; }
        public string categoryName { get; set; }
        public List<string> tagList { get; set; }
        public List<MomentViewModel> momentList { get; set; }
        public List<CommentViewModel> commentList { get; set; }
        public List<RetellViewModel> retellList { get; set; }
        public List<ReportViewModel> reportList { get; set; }
    }

    public class RetellViewModel
    {

    }

    public class CommentViewModel
    {
        public ObjectId _id { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public string username { get; set; }
        public string thumbnail { get; set; }
        public string text { get; set; }
    }

    public class ReportViewModel
    {
        public ObjectId _id { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public string username { get; set; }
        public string thumbnail { get; set; }
        public string categoryName { get; set; }
        public string text { get; set; }
    }

    public class MomentViewModel
    {
        public ObjectId _id { get; set; }
        public string title { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public string locationString { get; set; }
        public string themeName { get; set; }
        public string photoUrlOriginal { get; set; }
        public string photoUrlTimeline { get; set; }
        public string photoUrlHexagon { get; set; }
        public string photoUrlHexagonPreview { get; set; }
        public string photoUrlActivity { get; set; }
        public string photoUrlProfilePreview { get; set; }
        public List<MomentLikeModel> likeList { get; set; }
    }

    public class MomentLikeModel
    {
        public ObjectId _id { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public string username { get; set; }
        public string thumbnail { get; set; }
    }
}
