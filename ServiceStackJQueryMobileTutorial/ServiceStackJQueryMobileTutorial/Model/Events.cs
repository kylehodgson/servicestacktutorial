using System;
using System.Runtime.Serialization;
using ServiceStack.ServiceHost;

namespace ServiceStackJQueryMobileTutorial.Model
{
    [DataContract]
    [RestService("/events","GET")]
    [RestService("/events/page/{Page}","GET")]
    [RestService("/events/search/{SearchTerm}","GET")]
    public class Events
    {
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public DateTime EventDate { get; set; }
        [DataMember]
        public string Speaker { get; set; }
    }
}