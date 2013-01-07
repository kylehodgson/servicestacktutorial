using System;

namespace ServiceStackJQueryMobileTutorial.Model
{  
    public class Event
    {
        public string Subject { get; set; }
        public DateTime EventDate { get; set; }
        public string Speaker { get; set; }
        public DateTime EventStart { get; set; }
    }
}