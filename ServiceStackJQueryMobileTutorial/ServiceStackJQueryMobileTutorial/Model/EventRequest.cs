using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
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