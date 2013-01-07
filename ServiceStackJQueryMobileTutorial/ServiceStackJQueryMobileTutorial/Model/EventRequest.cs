using System.Runtime.Serialization;
using ServiceStack.ServiceHost;

namespace ServiceStackJQueryMobileTutorial.Model
{
    [DataContract]
    [RestService("/events", "GET")]
    [RestService("/events/page/{Page}", "GET")]
    [RestService("/events/search/{SearchTerm}", "GET")]
    public class EventRequest
    {
        [DataMember]
        public int? Page { get; set; }
        [DataMember]
        public string SearchTerm { get; set; }

        
    }
}