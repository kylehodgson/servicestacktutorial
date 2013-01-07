using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServiceStackJQueryMobileTutorial.Model
{
    [DataContract]
    public class EventsResponse
    {
        [DataMember]
        public IList<Event> EventListings { get; set; }
        [DataMember]
        public int RecordsPerPage { get; set; }
        [DataMember]
        public int CurrentPage { get; set; }
        [DataMember]
        public int? NextPage { get; set; }
        [DataMember]
        public bool IsLastPage { get; set; }
    }
}