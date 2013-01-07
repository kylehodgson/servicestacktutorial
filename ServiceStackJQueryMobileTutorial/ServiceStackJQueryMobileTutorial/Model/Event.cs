using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceStackJQueryMobileTutorial.Model
{
    public class Event
    {
        public int? Page { get; set; }

        public string SearchTerm { get; set; }

        public DateTime EventStart { get; set; }

        public string Speaker { get; set; }

        public string Subject { get; set; }
    }
}