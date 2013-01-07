using ServiceStack.ServiceInterface;
using ServiceStackJQueryMobileTutorial.Model;

namespace ServiceStackJQueryMobileTutorial.Service
{
    public class EventsService : RestServiceBase<Events>
    {
        public override object OnGet(Events request)
        {
            return new EventsResponse();
        }
    }
}