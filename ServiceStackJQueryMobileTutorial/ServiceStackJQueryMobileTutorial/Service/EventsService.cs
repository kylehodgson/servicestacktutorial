using ServiceStack.ServiceInterface;
using ServiceStackJQueryMobileTutorial.Model;
using ServiceStackJQueryMobileTutorial.Repository;

namespace ServiceStackJQueryMobileTutorial.Service
{
    public class EventsService : RestServiceBase<EventRequest>
    {
        private EventRepository repository;
        public EventsService()
        {
            repository = new EventRepository();
        }
        public EventsService(EventRepository repo)
        {
            repository = repo;
        }

        public override object OnGet(EventRequest request)
        {
            var list = repository.GetEvents();
            var output = new EventResponse
            {
                EventListings = list
            };

            return output;
        }
    }
}