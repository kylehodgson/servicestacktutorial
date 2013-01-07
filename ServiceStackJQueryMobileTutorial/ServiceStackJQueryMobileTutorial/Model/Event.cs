using System;
using System.Runtime.Serialization;
using ServiceStack.ServiceHost;

namespace ServiceStackJQueryMobileTutorial.Model
{
    [DataContract]
    [RestService("/events","GET")]
    [RestService("/events/page/{Page}","GET")]
    [RestService("/events/search/{SearchTerm}","GET")]
    public class Event
    {
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public DateTime EventDate { get; set; }
        [DataMember]
        public string Speaker { get; set; }
        [DataMember]
        public DateTime EventStart { get; set; }
    }
}